﻿using Datos;
using Newtonsoft.Json;
using Persistencia.UsuariosData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Productos
{
 
        public class ObtenerProductosWS
        {
        //private String adminId = "1653c7ec-870d-468a-b581-9800961d53d2";
        string usuario = "...";

        public String AgregarProducto(int idCategoria, string idUsuario, string idProveedor, String nombre, double precio, int stock)
            {
                // Crear el diccionario con los parámetros del producto
                Dictionary<String, Object> datos = new Dictionary<String, Object>
    {
        { "idCategoria", idCategoria },
        { "idUsuario", idUsuario },
        { "idProveedor", idProveedor },
        { "nombre", nombre },
        { "precio", precio },
        { "stock", stock }
    };

                // Convertir los datos a una cadena JSON
                var jsonData = JsonConvert.SerializeObject(datos);

                try
                {
                    // Enviar la solicitud POST al servicio web
                    HttpResponseMessage response = WebHelper.Post("Producto/AgregarProducto", jsonData);

                    // Si la respuesta no es exitosa, retornar "Error" sin lanzar una excepción
                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        return "Error";
                    }

                    // Leer la respuesta y deserializarla
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    var resultado = JsonConvert.DeserializeObject<String>(reader.ReadToEnd());

                    return resultado; // Devolver el resultado del servicio web
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine($"Excepción: {ex.Message}");
                    return "Error";
                }
            }

            public List<ProductoWS> buscarDatosProductos()
            {
                List<ProductoWS> productos = new List<ProductoWS>();

                try
                {
                    HttpResponseMessage response = WebHelper.Get("Producto/TraerProductos");

                    // Imprimir el contenido de la respuesta para depuración
                    // Console.WriteLine($"Contenido de la respuesta: {contentStream}");


                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        return null; // Devuelve null si hay un problema
                    }

                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<ProductoWS> listadoProductos = JsonConvert.DeserializeObject<List<ProductoWS>>(contentStream);

                    // Imprimir la cantidad de productos obtenidos para depuración
                    Console.WriteLine($"Cantidad de productos obtenidos: {listadoProductos.Count}");

                    return listadoProductos;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Excepción: {ex.Message}");
                    return null;
                }
            }


        // Método para actualizar producto
        public bool ModificarProducto(string idproducto, double precio, int stock)
        {
            string idusuario = "1653c7ec-870d-468a-b581-9800961d53d2";
            // Crear el diccionario con los parámetros del producto actualizado
            Dictionary<String, Object> datos = new Dictionary<String, Object>
            {
                { "id", idproducto },
                { "idUsuario", idusuario },
                { "precio", precio },
                {"stock", stock }
            };

            // Convertir los datos a una cadena JSON
            var jsonData = JsonConvert.SerializeObject(datos);

            try
            {
                // Enviar la solicitud POST al servicio web para actualizar el producto
                HttpResponseMessage response = WebHelper.Patch("Producto/ModificarProducto", jsonData);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return false;
                }

                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                var resultado = JsonConvert.DeserializeObject<String>(reader.ReadToEnd());

                return true; // Devolver el resultado del servicio web
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
                return false;
            }
        }
        // Nuevo método para eliminar producto
        public bool EliminarProducto(string idProducto)
        {
            
            try
            {
                // Crear diccionario de datos con el ID del producto a eliminar
                Dictionary<string, object> datos = new Dictionary<string, object>
                {
                    { "idProducto", idProducto },
                    { "IdUsuario", usuario }
                };

                // Convertir los datos a JSON
                var jsonData = JsonConvert.SerializeObject(datos);

                // Enviar la solicitud DELETE al servicio web
                HttpResponseMessage response = WebHelper.Post("api/Producto/BajaProducto", jsonData);

                if (response.IsSuccessStatusCode)
                {
                    // Si la respuesta es exitosa, el producto se eliminó
                    return true;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
                return false;
            }
        }
        public List<ProductoWS> ObtenerProductosOrdenadosPorStock()
        {
            try
            {
                // Realiza una solicitud GET para obtener los productos
                HttpResponseMessage response = WebHelper.Get("Producto/TraerProductos");

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return null;
                }

                // Procesa la respuesta
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<ProductoWS> productos = JsonConvert.DeserializeObject<List<ProductoWS>>(contentStream);

                // Ordena por stock ascendente
                return productos.OrderBy(p => p.Stock).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
                return null;
            }
        }
    }


}
