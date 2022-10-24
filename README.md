# Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**
1. [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
1. [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
1. [“Russia”, “Denmark”, “Kazan”] → []

# Решение:

*Программа написана следующим образом:*
* два метода; 
* основной код; 
* комментарии.

*Первоначальный массив задан на старте выполнения алгоритма.
Наименование имеющегося массива **array**.
В нём 4 элемента (4 строки):*
**[Hello, 2, world, :-)]**

## FormArrayElements1To3Characters
*Это метод для формирования нового массива из строк, длина которых меньше, либо равна 3 символам. 
Принимает на входе имеющийся массив **array**. 
Считает в нём количество строк (элементов массива), длина которых меньше, либо равна 3 символам. Поэлементно, с 0 до последнего.
Записывает количество необходимых для нового массива элементов в переменную **number**.
Создает новый массив **newArr** с количеством элементов **number**.
Если в имеющемся на входе массиве есть строки, длина которых меньше, либо равна 3 символам, заполняет этими строками новый массив **newArr**.
Метод **FormArrayElements1To3Characters** возвращает новый сформированный массив **newArr.***

## PrintArray
*Это метод для вывода всех элементов, принимаемого на входе массива, в консоль.
Для наглядности вывод массива начинается со знака "[" и заканчивается "]", элементы массива выводятся через запятую.*