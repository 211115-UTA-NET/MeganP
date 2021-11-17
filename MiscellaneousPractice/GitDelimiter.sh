#! user/bin/bash

echo "Enter File Name to Push:"
read fileName

git add fileName

echo "Enter Commit Message:"
read commitMessage

git commit -m "$commitMessage"

fileParts=$(echo $fileName | tr ".")

echo fileParts[0]

if [ $fileParts[1] = "txt" ] ||  [ $fileParts[1] = "sh" ] || [ $fileParts[1] = "png" ] || [ $fileParts[1] = "md" ]
do
	git push
fi

