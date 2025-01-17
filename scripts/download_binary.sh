#!/usr/bin/env bash
scriptdir=`dirname "$0"`

d="Darwin"
l="Linux"
if [[ "$(uname -s | grep ${d})" != "" ]]; then
  osn="macosx"
elif [[ "$(uname -s | grep ${l})" != "" ]]; then
  osn="linux"
else
  osn="windows"
fi

plugin="${scriptdir}/contract_csharp_plugin"

version="v1.0.3"

if [[ ! -f ${plugin} ]]; then
    if [[ ${osn} == "macosx" ]]; then
        suffix="osx"
    elif [[ ${osn} == "linux" ]]; then
        suffix="linux"
    fi
    filename=contract_csharp_plugin-${version}-${suffix}.zip
    # Make sure you grab the latest version
    if [[ ! -f ${filename} ]]; then
        echo "download contract plugin ${filename} from github"
        curl -OL https://github.com/GandalfProject/contract-plugin/releases/download/${version}/${filename}
    fi
    
    # Unzip
    unzip -o ${filename} -d "${scriptdir}"
fi
