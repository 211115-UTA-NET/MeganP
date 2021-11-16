#! user/bin/bash

read x
read y

if [ $x -gt $y ]
then
    echo "X is greater than Y"
fi

if [ $x = $y ]
then
    echo "X is equal to Y"
fi

if [ $x -lt $y ]
then
    echo "X is less than Y"
fi
