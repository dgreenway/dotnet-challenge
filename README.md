# Coding Challenge

## PART 1

Given an input of an array of numbers, return a string with the numbers sorted and sequences formatted as a hyphen separated range.

| Input                                | Output              |
| ------------------------------------ | ------------------- |
| [9, 3, 5, 2, 13, 4]                  | "2-5, 9, 13"        |
| [14, 13, 3]                          | "3, 13, 14"         |
| [5, 3, 1, 14, 11, 13, 10, 4, 19, 12] | "1, 3-5, 10-14, 19" |
| []                                   | ""                  |
| [3, 1, 18, 0, 2, 10, 17, 19]         | "0-3, 10, 17-19"    |

## PART 2 (time permitting)

Given an input of an array of date formatted strings within a 1 week window, return a string that represents those dates
Concatenate adjacent days of the week, and comma separate non-adjacent days

| Input                                                    | Output           |
| -------------------------------------------------------- | ---------------- |
| ["2021-08-25", "2021-08-24", "2021-08-23"]               | "Mon - Wed"      |
| ["2021-08-24", "2021-08-25"]                             | "Tue, Wed"       |
| ["2021-08-28", "2021-08-25", "2021-08-26", "2021-08-24"] | "Tue - Thu, Sat" |

## PART 3 (time permitting)

Support times as well.

| Input                                                                                                                                   | Output                                |
| --------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------- |
| ["2021-08-23T11:00:00Z/2021-08-23T13:00:00Z", "2021-08-24T11:00:00Z/2021-08-24T13:00:00Z", "2021-08-25T11:00:00Z/2021-08-25T13:00:00Z"] | "Mon - Wed, 11:00 - 13:00"            |
| ["2021-08-23T13:00:00Z/2021-08-23T14:00:00Z", "2021-08-25T14:00:00Z/2021-08-25T15:00:00Z"]                                              | "Mon 13:00 - 14:00, Wed 14:00 - 15:00 |