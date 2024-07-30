# FinalTask
## Задача : 
### Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
## Описание алгоритма решения:

1. Создаем фунцию Main и вызываем ее в конце

2. Создаем первый массив типа string который содержит в себе как символы так и буквенные значения

3. Сздаем второй массив типа string который пока ничего не содержит в себе, для него только выделена память которая равна размеру первого массива

3. Создаем функцию Void для вывода нового массива в терминал которая принимает в себя два массива
        
        В функции void:
        1.создаем цикл for 
        (текущий индекс = 0; текущий индекс < размер массива; текущий индекс увеличивается на 1)
        2.в нем создаем условие 
        if(элемент массива с текущим индексом меньше или равен 3) 
            3.если условие не выполняется переходим к циклу for
        4.если условие выполняется присваиваем этот элемент массива с текущим индексом элементу массива во втором массиве
        5.выводим в терминал второй массив
    
### Реализация алгоритма по пути Task/Program.cs