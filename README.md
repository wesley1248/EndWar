# EndWar - Verificador de Equações

Este é um programa simples em C# que permite ao usuário verificar se uma equação digitada bate com o conceito do "EndWar" na ciência da computação.

## Descrição

O programa solicita ao usuário que digite uma equação no formato "A + B = C", onde A, B e C são números inteiros. Em seguida, ele verifica se, ao inverter os dígitos de cada número (por exemplo, 123 se tornaria 321), a equação continua sendo verdadeira.

Por exemplo:
- Se o usuário digitar "123 + 456 = 579", o programa inverte os dígitos e verifica se "321 + 654 = 975". Como essa afirmação é verdadeira, o programa exibirá "True".
- Se o usuário digitar "100 + 20 = 300", o programa inverte os dígitos e verifica se "001 + 02 = 003". Como essa afirmação é falsa, o programa exibirá "False".

## Como Executar o Programa

1. Certifique-se de ter o ambiente de execução do C# configurado em seu computador.
2. Copie o código fornecido e cole-o em um novo projeto do C# em seu editor de código preferido.
3. Compile e execute o programa.

## Como Funciona

O programa começa solicitando ao usuário que digite uma equação no formato "A + B = C". A entrada do usuário é armazenada na variável `entradaDoUsuario`. Em seguida, a string é dividida em três partes usando o método `Split()` e armazenadas nas variáveis `partes` (um array de strings).

As partes da equação são invertidas usando o método `inverter()`, que utiliza a função `Array.Reverse()` para inverter o array de caracteres. Em seguida, as partes são convertidas de volta para inteiros usando o método `int.Parse()` e a soma entre as duas primeiras partes é comparada com a terceira parte para verificar se a equação é verdadeira ou falsa.

O resultado da verificação é armazenado na variável `resultado` e, em seguida, exibido no console.

## Contribuição

Se você quiser contribuir para aprimorar o programa ou corrigir possíveis problemas, sinta-se à vontade para fazer um fork do repositório, fazer suas alterações e criar um pull request. Sua contribuição será bem-vinda!

## Nota

O "EndWar" é uma representação imaginária e não tem nenhuma relação com a ciência da computação na realidade. O programa é apenas uma brincadeira para verificar a validade de equações após inverter os dígitos dos números. Divirta-se experimentando!
