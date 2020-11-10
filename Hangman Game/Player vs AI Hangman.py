import random  # imports collections of functions for use within the code
import sys
import time

easy = []  # seperate arrays for each hardness level of the game
medium = []
hard = []
game1 = 0
while game1 == 0:  # makes the player choose a difficulty and then only chooses words of certain length dependant on choice
    game = input("Easy, Medium or Hard: ")
    if game in 'easyEasymediumMediumhardHard':
        if game == 'Easy':
            for line in open('Hangman\words.txt'):
                line.strip()
                if 4 <= len(line) <= 5:
                    easy.append(line)
            word = random.choice(easy)
            game1 = 1
        elif game == 'Medium':
            for line in open('Hangman\words.txt'):
                line.strip()
                if 6 <= len(line) <= 9:
                    medium.append(line)
            word = random.choice(medium)
            game1 = 2
        elif game == 'Hard':
            for line in open('Hangman\words.txt'):
                line.strip()
                if 10 <= len(line) <= 13:
                    hard.append(line)
            word = random.choice(hard)
            game1 = 3
        else:  # if they guess either nothing or wrong term then they have to retry
            print("\nRetry\n")
length = int(len(word))
word = word[0:length-1]
if length < 13:  # chooses the length of the wrong guesses for the AI and player
    if length < 11:
        if length < 9:
            if length < 7:
                wrong2 = 7
            else:
                wrong2 = 9
        else:
            wrong2 = 11
    else:
        wrong2 = 13
else:
    wrong2 = 15


def ai():  # AI's definition
    astrix2 = len(word)*("*")  # creates the astrixes
    wrong = wrong2 + 2  # adds two incorrect guesses so the AI is a more difficult challenger
    guesslist2 = []  # empty guesslist
    while wrong > 0 and not astrix2 == word:  # stays in loop until the AI finishes the game
        guess = guessing()  # Ai's guessing function being called
        if guess in guesslist2:  # if the guess has already been guessed then wait 2 seconds then retry
            time.sleep(2)
        elif guess in word:  # if the guess is in the word
            # update the astrixes with the astrix function
            astrix2 = update_astrix(word, astrix2, guess)
            print(
                "\nThe AI guessed a right letter! The current Guessed word is " + str(astrix2))
            guesslist2.append(guess)  # adds guess to guesslist
            # if the AI hasn't finished the game then they continue if not then the game ends
            if wrong > 0 and not astrix2 == word:
                print("\nThe AI has " + str(wrong) + " wrong guesses left.")
                time.sleep(2)  # wait for 2 seconds before next guess
            else:
                if astrix2 == word:
                    print("\nThe AI got the word right! The word is: " + str(word))
                    print("\nThank you for playing this game! Hope you play again")
                    sys.exit()
                elif wrong <= 0:
                    print(
                        "\nThe AI guessed too many wrong letters! The word is: " + str(word))
                    print("\nThank you for playing this game! Hope you play again")
                    sys.exit()
        else:  # when the AI guesses wrong then this happens
            print("\nThe AI guessed a wrong letter!")
            wrong = wrong - 1  # they lose one wrong guess
            guesslist2.append(guess)
            if wrong > 0 and not astrix2 == word:
                print("\nThe AI has " + str(wrong) + " wrong guesses left.")
                time.sleep(2)
            else:
                if astrix2 == word:
                    print("\nThe AI got the word right! The word is: " + str(word))
                    print("\nThank you for playing this game! Hope you play again")
                    sys.exit()
                elif wrong <= 0:
                    print(
                        "\nThe AI guessed too many wrong letters! The word is: " + str(word))
                    print("\nThank you for playing this game! Hope you play again")
                    sys.exit()
    else:  # game finishing win or lose arguments
        if astrix2 == word:
            print("\nThe AI got the word right! The word is: " + str(word))
            print("\nThank you for playing this game! Hope you play again")
            sys.exit()
        elif wrong <= 0:
            print("\nThe AI guessed too many wrong letters! The word is: " + str(word))
            print("\nThank you for playing this game! Hope you play again")
            sys.exit()


def player():  # mostly identical to the AI function
    astrix1 = len(word)*("*")
    wrong = wrong2
    guesslist1 = []
    while wrong > 0 and not astrix1 == word:
        guess = input("\nGuess a letter: ")  # player inputs their guess
        if guess not in 'abcdefghijklmnopqrstuvwxyz':  # when the guess isn't a letter then they have to reguess
            print("Stop cheating!")
        elif len(guess) > 1:  # if the guess is more or less than one letter then they retry unless the guess is the complete word
            if guess == word:
                print("Wow you guessed the full word! The word is: " +
                      str(word) + '.')
                print("\nNow it's the AI's Turn")
                time.sleep(2)
                ai()
            else:
                print("Stop cheating!")
        elif len(guess) < 1:
            print("Stop cheating!")
        elif guess in guesslist1:
            print("\nYou've already guessed that letter, guess again!")
        elif guess in word:
            astrix1 = update_astrix(word, astrix1, guess)
            print(
                "\nThat letter is in the word! The current Guessed word is " + str(astrix1))
            guesslist1.append(guess)
            if wrong > 0 and not astrix1 == word:
                print("\nYou have " + str(wrong) + " wrong guesses left.")
            else:
                if astrix1 == word:
                    print("\nYou got the word right! The word is: " +
                          str(word) + '.')
                    print("\nNow it's the AI's Turn")
                    time.sleep(2)
                    ai()
                elif wrong <= 0:
                    print(
                        "\nYou guessed too many wrong letters! The word is: " + str(word) + '.')
                    print("\nNow it's the AI's Turn")
                    time.sleep(2)
                    ai()
        else:
            print("\nThat letter is not in the word")
            wrong = wrong - 1
            guesslist1.append(guess)
            if wrong > 0 and not astrix1 == word:
                print("\nYou have " + str(wrong) + " wrong guesses left.")
            else:
                if astrix1 == word:
                    print("\nYou got the word right! The word is: " +
                          str(word) + '.')
                    print("\nNow it's the AI's Turn")
                    time.sleep(2)
                    ai()
                elif wrong <= 0:
                    print(
                        "\nYou guessed too many wrong letters! The word is: " + str(word) + '.')
                    print("\nNow it's the AI's Turn")
                    time.sleep(2)
                    ai()
    else:
        if astrix1 == word:
            print("\nYou got the word right! The word is: " + str(word) + '.')
            print("\nNow it's the AI's Turn")
            time.sleep(2)
            ai()
        elif wrong <= 0:
            print("\nYou guessed too many wrong letters! The word is: " + str(word) + '.')
            print("\nNow it's the AI's Turn")
            time.sleep(2)
            ai()


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


def guessing():
    letter = []
    # takes all words on the word list and makes it letters then appends them
    for line in open('Hangman\words.txt'):
        k = list(line)
        letter.append(k)
    # randomly choose a letter from the array
    guess = random.choice(str(letter))
    guess.strip()
    # if the guess isn't in the alphabet then reguess
    while guess not in 'abcdefghijklmnopqrstuvwxyz' and not len(guess) != 1:
        guess = random.choice(str(letter))
        guess.strip()
    return guess


player()  # runs the player function function
