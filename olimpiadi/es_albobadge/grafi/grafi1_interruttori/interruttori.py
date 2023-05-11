import sys

sys.stdin = open('input.txt')
sys.stdout = open('output.txt', 'w')

def solve():
    input()
    N, A, B = map(int, input().split())
    Z = [None] * A
    X = [None] * B
    Y = [None] * B

    for j in range(A):
        Z[j] = int(input())
    for j in range(B):
        X[j], Y[j] = map(int, input().split())
    
    idx = 42 # memorizza qui l'indice della lampadina
    num = A + B # memorizza qui il numero di interruttori
    
    

    return (idx, num)


T = int(input())

for t in range(1, T+1):
    print("Case #{}: {} {}".format(t, *solve()))