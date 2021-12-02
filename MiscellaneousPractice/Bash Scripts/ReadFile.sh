#! user/bin/bash

input="ExampleFile.txt"
while IFS= read -r line
do
  echo "$line"
done < "$input"

read pause
