import collections
import string

wordsfile = open('words.txt', "r")
number = wordsfile.read().upper()
letters = collections.Counter(number)
for letter, number in letters.most_common():
    if letter in string.ascii_uppercase:
        print(letter.lower(), number)
