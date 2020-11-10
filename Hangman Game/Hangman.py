import random  # imports collections of functions for use within the code
import sys

words = []  # The array the words are added to
for line in open('words.txt'):  # appends the words
    words.append(line)
word = random.choice(words)  # chooses the word
word.strip()
if len(word) > 13:  # rechooses if the word is to long or short
    word = random.choice(words)
    word = word.strip()
elif len(word) < 5:
    word = random.choice(words)
    word = word.strip()
length = int(len(word)-1)
print(word)
word = word[0:int(length)]
wordlist = list(word)


def get_guess():  # main game code for the player
    astrix = length*("*")
    astrixlist = list(astrix)
    if length < 13:  # changes the amount of incorrect guess dependant on length of word
        if length < 11:
            if length < 9:
                if length < 7:
                    wrong = 7
                else:
                    wrong = 9
            else:
                wrong = 11
        else:
            wrong = 13
    else:
        wrong = 15
    guesslist = []
    while wrong > 0 and not astrix == word:  # stays in loop until the game should finish
        guess = input("\nGuess a letter: ")  # players guess
        if len(guess) != 1:  # if the guess is more or less than one letter
            print("Retry.\nThe current Guessed word is " + str(astrix))
        elif guess in guesslist:  # if the guess has already been guessed
            print("\nYou've already guessed that letter, guess again!\n\nThe current Guessed word is " + str(astrix))
        elif guess in word:  # if the guess is correct
            # calls the astrix function
            astrix = update_astrix(word, astrix, guess)
            print(
                "\nThat letter is in the word! The current Guessed word is " + str(astrix))
            guesslist.append(guess)  # adds guess to guesslist
            # if the player hasn't finished the game then they continue if not then the game ends
            if wrong > 0 and not astrix == word:
                print("\nYou have " + str(wrong) + " wrong guesses left.")
            else:
                if astrix == word:
                    print("You Won! The word is: " + str(word))
                    sys.exit()
                elif wrong >= 0:
                    print("You ran out of incorrect guesses. The word is: " + str(word))
                    sys.exit()
        else:  # when the player guesses wrong then this happens
            print(
                "\nThat letter is not in the word.\n\nThe current Guessed word is " + str(astrix))
            wrong = wrong - 1  # they lose one wrong guess
            guesslist.append(guess)
            if wrong > 0 and not astrix == word:
                print("\nYou have " + str(wrong) + " wrong guesses left.")
            else:
                if astrix == word:
                    print("You Won! The word is: " + str(word))
                    sys.exit()
                elif wrong >= 0:
                    print("You ran out of incorrect guesses. The word is: " + str(word))
                    sys.exit()
    else:  # game finishing win or lose arguments
        if wrong >= 0:
            print("You ran out of incorrect guesses. The word is: " + str(word))
            sys.exit()
        else:
            print("You Won! The word is: " + str(word))
            sys.exit()


# function for updating astrixes asks for the secret word, the astrixs and the current guess
def update_astrix(secword, curastrix, curguess):
    result = ''
    for i in range(len(word)):
        # makes the astrix the current guess if it's in the word else it stays as an astrix
        if word[i] == curguess:
            result = result + curguess
        else:
            result = result + curastrix[i]
    return result  # returns the result for the argument call


get_guess()  # runs the game function
