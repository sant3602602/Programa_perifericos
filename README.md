# Programa_perifericos
# Sistema de Gestión de Periféricos
#Santiago Morales Toro
#ID: 264090
## Nota sobre el desarrollo del proyecto

Este trabajo fue realizado de manera individual debido a mi disponibilidad limitada de tiempo para coordinar reuniones con compañeros, ya que actualmente estoy combinando responsabilidades de trabajo y estudio.

Por esta razón, el desarrollo del sistema, el diseño del diagrama UML y la implementación del código fueron realizados completamente por mi.

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



## Relaciones del Diagrama de Clases

En el sistema se implementan diferentes tipos de relaciones de Programación Orientada a Objetos para modelar correctamente cómo interactúan las entidades dentro del sistema de gestión de periféricos.

### Herencia

Se implementa una relación de herencia entre la clase **Periferico** y las clases **Teclado**, **Mouse** y **Monitor**.

Esto se debe a que todos estos dispositivos son tipos de periféricos, por lo que comparten características comunes como el nombre, la marca y el precio.  
La clase **Periferico** funciona como clase base, mientras que **Teclado**, **Mouse** y **Monitor** son clases derivadas que heredan estos atributos y además agregan sus propias características específicas.

### Asociación

Se implementa una relación de asociación entre las clases **Usuario** y **Asignacion**.

Esta relación representa que un usuario puede tener varias asignaciones de periféricos dentro del sistema.  
La clase **Asignacion** permite registrar qué usuario tiene asignado un periférico y en qué fecha se realizó dicha asignación.

### Agregación

Se utiliza una relación de agregación entre **Asignacion** y **Periferico**.

Esto significa que una asignación está relacionada con un periférico específico, pero el periférico puede existir dentro del sistema de forma independiente, incluso si no está asignado a ningún usuario.

### Implementación de Interfaz

El sistema define una interfaz llamada **ICrud**, la cual contiene las operaciones básicas de gestión de datos: **crear, leer, actualizar y eliminar registros**.

Las clases **PerifericoService**, **UsuarioService** y **AsignacionService** implementan esta interfaz para garantizar que todas manejen las mismas operaciones CRUD, pero aplicadas a las diferentes entidades del sistema.

De esta manera se mantiene una estructura organizada, reutilizable y alineada con los principios de la Programación Orientada a Objetos.
