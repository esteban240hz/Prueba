using Xunit;
using Lib;
namespace testOperaciones;

public class UnitTest1
 {
        [Theory]
        [InlineData(2, 3, 5)] // Prueba con datos fijos
        [InlineData(3, 3, 6)] // Corregir el valor esperado de esta prueba
        [InlineData(4, 11, 15)] // Corregir el valor esperado de esta prueba
        [InlineData(12, 55, 67)] // Corregir el valor esperado de esta prueba
        [InlineData(4, 1, 5)] // Corregir el valor esperado de esta prueba
        public void testSuma(int a, int b, int resultadoEsperado)
        {
            // AAA Arrange Act Assert
            // Arrange: Preparar los datos de entrada
            int resultadoReal;

            // Act: Invocar al método
            resultadoReal = operacionesBasicas.suma(a, b);

            // Assert: Verificar el resultado
            Assert.Equal(resultadoEsperado, resultadoReal);
        }
    }