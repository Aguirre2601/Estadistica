# 📊 StatAnalyzer: Calculadora de Estadística Descriptiva

StatAnalyzer es una herramienta robusta desarrollada en C# diseñada para automatizar el cálculo de medidas de tendencia central tanto para datos desagrupados como para datos agrupados por intervalos. La aplicación ofrece una interfaz intuitiva para estudiantes y profesionales que requieren procesar conjuntos de datos de manera rápida y precisa.

## ✨ Características Principales

El sistema se divide en dos módulos especializados según la naturaleza de la muestra:

1. Módulo de Datos Desagrupados

        Ideal para muestras pequeñas donde cada observación es independiente.

        Media Aritmética ($\bar{x}$): Cálculo del promedio simple de la muestra.
  
        Mediana ($\tilde{x}$): Identificación del valor central tras el ordenamiento automático de los datos.
  
        Moda ($Mo$): Determinación del valor o valores con mayor frecuencia de aparición.
  
2. Módulo de Datos Agrupados

        Diseñado para manejar grandes volúmenes de datos organizados en tablas de frecuencias por intervalos.

        Generación de Tabla de Frecuencias: Gestión de límites (inferior/superior), marcas de clase ($x_i$) y frecuencias absolutas ($f_i$).
  
        Cálculo de Parámetros: * Media Agrupada: Basada en el sumatorio de marcas de clase por frecuencia.
  
        Mediana y Moda Agrupada: Implementación de fórmulas de interpolación lineal basadas en las clases mediana y modal.

## 🛠️ Detalles Técnicos

Arquitectura y Diseño

  -Lógica de Cálculo Separada: La clase Calcula centraliza todas las operaciones matemáticas, permitiendo que las interfaces (FormDatosD y FormDatosAgurp) se encarguen exclusivamente de la interacción con el usuario.

  -Validación de Datos: Incluye controles para asegurar que las entradas sean numéricas y que los intervalos en datos agrupados mantengan coherencia lógica.

Fórmulas Implementadas

El motor de cálculo utiliza las siguientes expresiones matemáticas:

    Media Agrupada: $$\bar{x} = \frac{\sum (x_i \cdot f_i)}{n}$
  
    $Moda Agrupada: $$Mo = L_i + \left( \frac{d_1}{d_1 + d_2} \right) \cdot A$$
  
## 🚀 Instalación y Uso

Requisitos: Tener instalado .NET Framework 4.5 o superior y Visual Studio.

Ejecución:

  Clona el repositorio.
  
  Abre el archivo CapaCalculadora.sln.
  
  Presiona F5 para compilar y ejecutar.
  
  Flujo de trabajo:Selecciona el tipo de datos en el menú principal (Form1).
  
  Ingresa tus datos o define los intervalos de clase.
  
  Haz clic en Calcular para obtener los resultados instantáneamente.
  
## 🏗️ Estructura del Proyecto

  Calcula.cs: El cerebro del proyecto; contiene los algoritmos estadísticos.
  
  FormDatosD.cs: Interfaz y lógica para datos simples.
  
  FormDatosAgurp.cs: Interfaz y lógica para tablas de frecuencias.
  
  Diseño.cs: Utilidades para la experiencia de usuario y estética visual.
