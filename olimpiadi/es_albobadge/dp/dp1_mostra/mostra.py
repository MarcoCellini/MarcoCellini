import sys

sys.stdin = open('mostra_input_5.txt')
sys.stdout = open('output.txt', 'w')

matrix = [[-1 for column in range(1010)] for row in range(1010)]

def recursive(visitatori, guide, n_vis, n_guide):
    if n_guide == 0:
        return n_vis
    if n_vis == 0:
        return 0
    if (matrix[n_vis][n_guide] == -1):
        if recursive(visitatori, guide, n_vis, n_guide + 1) > recursive(visitatori, guide, n_vis - 1, n_guide) + 1:
            tmp = recursive(visitatori, guide, n_vis, n_guide + 1)
        else:
            tmp = recursive(visitatori, guide, n_vis - 1, n_guide) + 1
        if visitatori[n_vis - 1] >= guide[n_guide - 1]:
            matrix[n_vis][n_guide] = tmp
        else:
            if tmp <= recursive(visitatori, guide, n_vis - 1, n_guide - 1) + 2:
                tmp = recursive(visitatori, guide, n_vis - 1, n_guide - 1) + 2
            matrix[n_vis][n_guide] = tmp
    return matrix[n_vis][n_guide]

def solve():
    input()
    N, M = map(int, input().split())
    V = list(map(int, input().split()))
    G = list(map(int, input().split()))

    if M == 0:
        return N
    elif N == 0:
        return 0
    else:
        risultato = recursive(V, G, N, M)
        
    return risultato


T = int(input())

for t in range(1, T+1):
    print("Case #" + str(t) + ":", solve())