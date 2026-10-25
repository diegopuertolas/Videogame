# Videojuego

Crear una clase abstracta:

```csharp
Personaje
```

con las propiedades:

- Nombre.
- Vida.

Definir el método:

```csharp
public abstract string ObtenerDescripcion();
```

Crear las siguientes clases:

```text
Personaje
 |
 +-- Guerrero
 |
 +-- Mago
 |
 +-- Arquero
```

Cada clase tendrá una propiedad específica:

- `Guerrero`: Fuerza.
- `Mago`: Mana.
- `Arquero`: NumeroFlechas.

Crear varios personajes y almacenarlos en:

```csharp
List<Personaje>
```

Recorrer la colección y mostrar la descripción de cada personaje.

Responder:

1. ¿Por qué `Personaje` puede ser una clase abstracta?
Personaje es una clase abstracta ya que define lo que las clases que hereden de ella deben implementar y sobreescribir.

2. ¿Por qué un `Mago` puede almacenarse en una variable de tipo `Personaje`?
Porque un Mago es a su vez un Personaje, así lo definimos en la definición de la clase Mago, al decir que hereda de Personaje.

3. ¿Qué método `ObtenerDescripcion()` se ejecutará para cada objeto?
Se ejecutará el método GetDescription() propio de cada clase, ya que todas las que hereden de Personaje deben sobreescribirlo. 