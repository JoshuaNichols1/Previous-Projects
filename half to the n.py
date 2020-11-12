import math

Type = input('What Type (A, N, M)? ')


def give(givens):
    a = []
    g = givens.split()
    print(g)
    for i in g:
        a.append(i)
    return a


def needshalf(t, x, xo):
    answer = (math.log2(x/xo))*float(t)
    answer = answer * -1
    return answer


def needst(half, x, xo):
    answer = (math.log2(x/xo))*float(half)
    answer = answer * -1
    return answer


def needsx(half, t, xo):
    answer = float(xo)*(1/2) ** (t/half)
    return answer


def needsxo(half, t, x):
    answer = float(x)/((1/2) ** (half/t))
    return answer


Givens = input(
    'Givens (order: t 1/2, t, X, Xo. If haven\'t got then put in ?) ')
a = give(Givens)
half = a[0]
time = a[1]
X = a[2]
Xo = a[3]
if Type == 'A':
    if half == '?':
        answer = needshalf(int(time), int(X), int(Xo))
        print(f'Half-Life = {answer}')
    elif time == '?':
        answer = needst(int(half), int(X), int(Xo))
        print(f'Time = {answer}')
    elif X == '?':
        answer = needsx(int(half), int(time), int(Xo))
        print(f'Activity = {answer}')
    elif Xo == '?':
        answer = needsxo(int(half), int(time), int(X))
        print(f'Original Activity = {answer}')
if Type == 'N':
    if half == '?':
        answer = needshalf(int(time), int(X), int(Xo))
        print(f'Half-Life = {answer}')
    elif time == '?':
        answer = needst(int(half), int(X), int(Xo))
        print(f'Time = {answer}')
    elif X == '?':
        answer = needsx(int(half), int(time), int(Xo))
        print(f'Number of Nuclei = {answer}')
    else:
        answer = needsxo(int(half), int(time), int(X))
        print(f'Original Number of Nuclei = {answer}')
if Type == 'M':
    if half == '?':
        answer = needshalf(int(time), int(X), int(Xo))
        print(f'Half-Life = {answer}')
    elif time == '?':
        answer = needst(int(half), int(X), int(Xo))
        print(f'Time = {answer}')
    elif X == '?':
        answer = needsx(int(half), int(time), int(Xo))
        print(f'Mass = {answer}')
    else:
        answer = needsxo(int(half), int(time), int(X))
        print(f'Original Mass = {answer}')
