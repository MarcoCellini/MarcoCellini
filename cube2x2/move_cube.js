/* 
    the main idea is use only 2 movement [R, R1]
    and create others changing the point of view of the cube
*/

const shift_right = (c) => {
    return [...c.slice(c.length -2), ...c.slice(0, c.length - 2)];
};

const rotate_dx = (c, f) => {
    return c.map((e, i) => i === f ? [[e[1][0], e[0][0]], [e[1][1], e[0][1]]] : e);
};

export const R = (cube) => {    
    let k = 0, l = cube.flat().flat().filter((_, i) => i < 16).filter((_, i) => i % 2);
    l = shift_right(l);
    return rotate_dx(cube.map((e, i) => i < 4 ? [[e[0][0], l[k++]], [e[1][0], l[k++]]] : e), 4);
};

const shift_left = (c) => {
    return [...c.slice(2), ...c.slice(0, 2)];
};

const rotate_sx = (c, f) => {
    return c.map((e, i) => i === f ? [[e[0][1], e[1][1]], [e[0][0], e[1][0]]] : e);
};

export const R1 = (cube) => {
    let k = 0, l = cube.flat().flat().filter((_, i) => i < 16).filter((_, i) => i % 2 !== 0);
    l = shift_left(l);
    return rotate_sx(cube.map((e, i) => i < 4 ? [[e[0][0], l[k++]], [e[1][0], l[k++]]] : e), 4);
};

export const U = (cube) => {
    Array.from(Array(6).keys()).map(e => e !== 2 ? cube = rotate_dx(cube, e) : cube = rotate_sx(cube, e));
    cube = [cube[0], cube[5], cube[2], cube[4], cube[1], cube[3]];
    cube = R(cube);
    Array.from(Array(6).keys()).map(e => e !== 2 ? cube = rotate_sx(cube, e) : cube = rotate_dx(cube, e));
    cube = [cube[0], cube[4], cube[2], cube[5], cube[3], cube[1]];
    return cube;
}

export const U1 = (cube) => {
    Array.from(Array(6).keys()).map(e => e !== 2 ? cube = rotate_dx(cube, e) : cube = rotate_sx(cube, e));
    cube = [cube[0], cube[5], cube[2], cube[4], cube[1], cube[3]];
    cube = R1(cube);
    Array.from(Array(6).keys()).map(e => e !== 2 ? cube = rotate_sx(cube, e) : cube = rotate_dx(cube, e));
    cube = [cube[0], cube[4], cube[2], cube[5], cube[3], cube[1]];
    return cube;
}

export const sexy_move = (c) => {
    return U1(R1(U(R(c))));
}