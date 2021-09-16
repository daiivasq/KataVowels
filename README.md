# KataVowels

# RGR: 
          Red -> Una SOLA PRUEBA que falle
          Green -> Hacer pasar la UNICA prueba que esta fallando
          Refactor -> Mejorar la mantenibiliad del codigo
           
           Plan de Prueba:
           DONE => n1. null -> throw ArgumentNullException
           DONE => p1. "" -> {}
           DONE => p4. "024821858" -> {}            
           DONE => p3. "hola@mundo.com" -> { 'a': 1,  'i' : 1, 'o': 3, 'u': 1 }
           DONE => p2. "INS-368" -> { 'i': 1 } //el contador sera Case Insensitive, y la salida sera minuscula
           DONE => px. "Murcielago x MURCIELAGO = mUrciElagO cuadrado" -> { 'a': 5, 'e': 3, 'i': 3, 'o': 4, 'u': 4 }
