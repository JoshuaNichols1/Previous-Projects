freqs = {}
with open('words.txt') as f:
    for line in f:
        for char in line:
            if char in freqs:
                freqs[char] += 1
            else:
                freqs[char] = 1

print(freqs)
