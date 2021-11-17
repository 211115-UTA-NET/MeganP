#! user/bin/bash

mkdir ExampleDir
touch ExampleFile.txt
echo "Hello Example File" > ExampleFile.txt
echo "I just concatenated to the file" >> ExampleFile.txt

touch ExampleDir/ExampleFileInExampleDir.txt
echo "In a differnt directory???? CRAZY!!!" > ExampleFIleInExampleDir.txt

for i in {1..19..2}
do 
	echo $i >> ExampleFile.txt
done


echo -n "2" >> ExampleFile.txt
for j in {4..20..2}
do 
	echo -n ", $j" >> ExampleFile.txt
done

echo $strNums >> ExampleFile.txt













