using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Counter.Tests
{
    public class Tests
    {
        
            // * RGR: 
            // *  Red -> Una SOLA PRUEBA que falle
            // *  Green -> Hacer pasar la UNICA prueba que esta fallando
            // *  Refactor -> Mejorar la mantenibiliad del codigo
            // * 
            // * Plan de Prueba:
            // *  DONE => n1. null -> throw ArgumentNullException
            // *  DONE => p1. "" -> {}
            // *  DONE => p4. "024821858" -> {}            
            // *  DONE => p3. "hola@mundo.com" -> { 'a': 1,  'i' : 1, 'o': 3, 'u': 1 }
            // *  DONE => p2. "INS-368" -> { 'i': 1 } //el contador sera Case Insensitive, y la salida sera minuscula
            // *  DONE => px. "Murcielago x MURCIELAGO = mUrciElagO cuadrado" -> { 'a': 5, 'e': 3, 'i': 3, 'o': 4, 'u': 4 }
            
        
        
        [Test]
        public void MethodWithNullArgumenthsExepctions()
        {
            Assert.Catch<ArgumentNullException>(() => VowelsCounter.Count(null));
        }
        [Test]
        public void CounterWithEmptyDictionary()
        {
            List<string> res = VowelsCounter.Count("");
            Assert.That(res, Is.Empty);
        }
        [Test]
        public void CounterWithNumberReturnEmptyDictionary()
        {
            List<string> res = VowelsCounter.Count("515554");
            Assert.That(res, Is.Empty);
        }
        [Test] 
        public void CounterWithEmailReturnVowels()
        {
            List<string> res = VowelsCounter.Count("Holamundo@gmail.com");
            List<string> exp = new List<string>
            {
                "a = 2","i = 1","o = 3","u = 1"
            };
            Assert.That(res, Is.EqualTo(exp));
        }
        [Test] 
        public void CounterWithCaseSensitive()
        {
            List<string> res = VowelsCounter.Count("INS-368");
            List<string> exp = new List<string>
            {
                "i = 1"
            };
            Assert.That(res, Is.EqualTo(exp));
        }
        [Test] 
       public void CounterWhenInputTextUpperAndInput()
       {
           List<string> res = VowelsCounter.Count("Murcielago x MURCIELAGO = mUrciElagO cuadrado");
           List<string> exp = new List<string>
           {
               "a = 5","e = 3","i = 3","o = 4","u = 4"
           };
          
           Assert.That(res, Is.EqualTo(exp));
       }
    }
}