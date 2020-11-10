def caesar_encrypt(Text, amount):
    outText = []
    uppercase = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z']
    lowercase = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
    for Letter in Text:
        if Letter == ' ':
            outText.append(Letter)
        elif Letter == Letter.upper():
            index = uppercase.index(Letter)
            encrypting = (index + amount)
            outText.append(uppercase[encrypting])
        elif Letter in lowercase:
            index = lowercase.index(Letter)
            encrypting = (index + amount)
            outText.append(lowercase[encrypting])
    return outText
message = input("Message: ")
key = int(input("Key: "))
code = caesar_encrypt(message, key)
print('Output: ' + ''.join(code))
