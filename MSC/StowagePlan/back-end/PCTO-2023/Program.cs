using container;
using ship;
using Test;
using computing;

Test.Program example = new Test.Program(2, 2, 2, 20);

float[] pesi = { 10, 11, 9, 8, 1, 2, 3, 4 };
int[] scarico = { 5, 5, 5, 5, 10, 10, 10, 10 };

example.ex1(pesi, scarico);