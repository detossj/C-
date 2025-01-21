using System;
using EjemploHerencia;

A miVariable = new A();
miVariable.atributoA = 5;

B otraVariable = new B();
otraVariable.atributoB = 5;
otraVariable.atributoA = 7;

Mueble mueble = new Mueble();

mueble.ancho = 2;
mueble.alto = 7;
mueble.material = "Madera";

Mesa mesa = new Mesa();
mesa.ancho = 4;

Silla sillas = new Silla();
sillas.ancho = 5;
sillas.respaldo = true;