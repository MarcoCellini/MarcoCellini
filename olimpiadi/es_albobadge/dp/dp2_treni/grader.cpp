#include <stdio.h>
#include <stdlib.h>
#include <assert.h>

int onlysuper(int n, int arr[]) {
  int tot = 0;
  for (int i = 0; i < n; i++)
    tot += arr[i];
  return tot;
}

int onlyhyper(int n, int arr[]) {
  int tot = 0;
  for (int i = 0; i < n; i += 2)
    tot += arr[i];
  return tot;
}

int special(int n, int super[], int hyper[]) {
  int tot = 0;
  super[0] > hyper[0] ? tot += super[0] : tot += hyper[0];
  printf("%i", tot);
  for (int i = 1; i < n; i++) {
    if (super[i] > hyper[i + 1])
      tot += super[i];
    else
      tot += hyper[++i];
  }
  return tot;
}

int tempo_massimo(int n, int super[], int hyper[]) {
  int casi[3] = {onlysuper(n, super), onlyhyper(n, hyper), special(n, super, hyper)};
  int max = -1;
  for (int i = 0; i < 3; i++)
    if (max < casi[i])
      max = casi[i];
  return max;
}

int main() {
  int n;
  FILE *in = stdin, *out = stdout;
  in = fopen("./input.txt", "r");
  out = fopen("./output.txt", "w");
  assert(fscanf(in, "%d", &n) == 1);

  int *a = (int *)calloc(n, sizeof(int));
  int *b = (int *)calloc(n, sizeof(int));

  for (int i = 0; i < n; i++) {
    assert(fscanf(in, "%d", a + i) == 1);
    assert(fscanf(in, "%d", b + i) == 1);
  }

  int answ = tempo_massimo(n, a, b);
  fprintf(out, "%d\n", answ);

  free(a);
  free(b);

  fclose(in);
  fclose(out);

  return EXIT_SUCCESS;
}