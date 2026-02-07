#!/bin/sh
printf '\033c\033]0;%s\a' Jam1
base_path="$(dirname "$(realpath "$0")")"
"$base_path/first game.x86_64" "$@"
