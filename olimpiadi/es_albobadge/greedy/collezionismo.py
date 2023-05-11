import sys

sys.stdin = open('input.txt')
sys.stdout = open('output.txt', 'w')

def solve(t):
    input()

    N, K = map(int, input().strip().split())

    C = list(map(int, input().strip().split()))

    C.sort()

    print(f"Case #{t}: {C}")


T = int(input().strip())

for t in range(1, T+1):
    solve(t)

sys.stdout.close()