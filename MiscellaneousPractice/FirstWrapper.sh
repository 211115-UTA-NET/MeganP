#! user/bin/bash

mkdir ExampleDir
touch ExampleFile.txt
echo "Hello Example File" > ExampleFile.txt
echo "I just concatenated to the file" >> ExampleFile.txt

touch ExampleDir/ExampleFileInExampleDir.txt
echo "In a differnt directory???? CRAZY!!!" > ExampleFIleInExampleDir.txt
