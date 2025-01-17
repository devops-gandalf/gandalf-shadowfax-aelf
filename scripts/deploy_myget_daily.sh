#!/usr/bin/env bash
set -ev

VERSION_PREFIX=$1
MYGET_API_KEY=$2

# days since 1970-1-1 as build version
BUILD_VERSION=`expr $(date +%s) / 86400`
VERSION=${VERSION_PREFIX}-${BUILD_VERSION}

src_path=src/
contract_path=contract/
build_output=/tmp/Gandalf-build

if [[ -d ${build_output} ]]; then
    rm -rf ${build_output}
fi

dotnet restore Gandalf.sln

for path in ${src_path} ${contract_path} ;
do
    cd ${path}
    echo '---- build '${path}

    for name in `ls -lh | grep ^d | grep Gandalf | grep -v Tests| awk '{print $NF}'`;
    do
        if [[ -f ${name}/${name}.csproj ]] && [[ 1 -eq $(grep -c "GeneratePackageOnBuild" ${name}/${name}.csproj) ]];then
            echo ${name}/${name}.csproj
            dotnet build /clp:ErrorsOnly ${name}/${name}.csproj --configuration Release -P:Version=${VERSION} -P:Authors=Gandalf -o ${build_output}

            echo `ls ${build_output}/${name}.${VERSION}.nupkg`
            dotnet nuget push ${build_output}/${name}.${VERSION}.nupkg -k ${MYGET_API_KEY} -s https://www.myget.org/F/Gandalf-project-dev/api/v3/index.json
        fi
    done
    cd ../
done
