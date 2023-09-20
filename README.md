# Web Scraping de Precios - Guía de Uso

Este programa es una aplicación diseñada para realizar web scraping en sitios web y obtener información de precios de productos. A continuación, te explicaremos cómo utilizarlo.

## Funcionalidades Principales

- **Selección del Motor del Navegador:** Puedes escoger entre varios motores de navegación, como Chrome, Edge, Firefox o Safari.

- **Ingreso de la URL:** Ingresa la URL del sitio web que deseas analizar. Actualmente, el programa está configurado para funcionar con Amazon.

- **Búsqueda de Productos:** Escribe el nombre de los productos que deseas buscar en el sitio web. Puedes escribir varios productos uno tras otro.

- **Presionar Enter:** Una vez que hayas escrito un producto, presiona la tecla "Enter" para buscarlo en el sitio web. Si deseas buscar más productos, simplemente escribe el siguiente y presiona "Enter" nuevamente.

- **Resolución del CAPTCHA:** Si el sitio web muestra un CAPTCHA y requiere tu intervención, tendrás 10 segundos para resolverlo manualmente. Luego, el programa continuará automáticamente.

- **Finalización del Proceso:** Una vez que hayas buscado todos los productos deseados, simplemente presiona "Enter" sin escribir nada para finalizar el proceso de web scraping.

- **Guardado del Archivo CSV:** El archivo CSV que contiene los resultados se guarda en la ubicación donde se compila el proyecto.

## Ejemplo de Uso

1. **Descarga y Compilación del Proyecto:**
    - Puedes descargar la última versión desde [aquí](https://github.com/Zurybr/Scrapier/releases/tag/v0.0.1).
    - Clona el repositorio desde GitHub o descárgalo como un archivo ZIP.
    - Abre una terminal y navega hasta la carpeta del proyecto.
    - Ejecuta el siguiente comando para compilar el proyecto:

      ```bash
      dotnet build
      ```

2. **Ejecución del Programa:**

    - Ejecuta el programa con el siguiente comando:

      ```bash
      dotnet run
      ```

3. **Configuración de Parámetros:**

    - Selecciona el motor del navegador, ingresa la URL del sitio web (por ejemplo, "https://www.amazon.com.mx/"), y escribe los nombres de los productos que deseas buscar.

4. **Uso del Programa:**

    - Sigue las instrucciones en la pantalla para buscar productos y resolver CAPTCHAs si es necesario.


## Notas Importantes

- Este programa actualmente está configurado para funcionar con Amazon, por lo que la URL ingresada debe ser de este sitio web.

- Asegúrate de tener instalado el controlador del navegador que seleccionaste antes de ejecutar el programa.

- El archivo CSV que contiene los resultados se guarda en la ubicación donde se compila el proyecto.

- Si tienes algún problema o pregunta, no dudes en ponerte en contacto con el desarrollador.

¡Disfruta de la experiencia de web scraping y obtén información de precios de productos de manera eficiente!
