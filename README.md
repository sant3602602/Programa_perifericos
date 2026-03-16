# Programa_perifericos
# Sistema de Gestión de Periféricos

## Enunciado del sistema

En muchas empresas, universidades o centros de trabajo se utilizan diferentes periféricos de computador como teclados, mouse y monitores. Estos dispositivos suelen ser asignados a distintos usuarios o empleados para que puedan realizar sus actividades. Sin embargo, cuando no existe un sistema para registrar y controlar estos periféricos, es común que se pierda información sobre qué dispositivos existen, quién los está utilizando o cuándo fueron asignados.

Por esta razón, se propone desarrollar un **Sistema de Gestión de Periféricos**, cuyo objetivo es permitir administrar de forma sencilla los dispositivos disponibles dentro de una organización.

El sistema permitirá registrar diferentes tipos de periféricos, como teclados, mouse y monitores, almacenando información relevante de cada uno, como su identificador, nombre, marca y precio. Además, se podrán registrar usuarios dentro del sistema, guardando datos como su nombre y correo electrónico.

Una de las funcionalidades principales del sistema es la **asignación de periféricos a usuarios**. Esto permitirá llevar un registro de qué periférico está siendo utilizado por cada usuario y en qué fecha fue asignado.

Para la administración de la información, el sistema implementa operaciones **CRUD (Create, Read, Update, Delete)** que permiten:

* Crear nuevos registros de periféricos, usuarios y asignaciones.
* Consultar o listar los registros almacenados en el sistema.
* Actualizar la información de los registros existentes.
* Eliminar registros cuando sea necesario.

El sistema se implementará como una **aplicación de consola en C#**, utilizando principios de **Programación Orientada a Objetos (POO)** como herencia, asociaciones entre clases, agregación e interfaces para organizar correctamente el diseño del programa.

Además, para mantener la información almacenada incluso después de cerrar la aplicación, se implementará un mecanismo de **persistencia de datos utilizando archivos CSV** mediante la librería CsvHelper. Esto permitirá guardar y cargar los datos de los periféricos, usuarios y asignaciones.

Con este sistema se busca demostrar la aplicación práctica de los conceptos vistos en el curso de **Paradigmas de Programación**, especialmente en lo relacionado con el diseño de clases, relaciones entre objetos y manejo de datos.
