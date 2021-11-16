#! user/bin/bash

read expression
value=` echo "$expression " | bc -l`
printf "%0.3f\n" $value
