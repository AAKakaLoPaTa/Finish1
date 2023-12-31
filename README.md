# Задание на работы

Урок 1. Контрольная работа
Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:\
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]\
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]\
[“Russia”, “Denmark”, “Kazan”] → []

# Блок-схема алгоритма

Блок-схема алгоритма указана в файле sxema.drawio

# Ссылка на репозиторий проекта

https://github.com/AAKakaLoPaTa/Finish1.git

# Описание решения

1. Программа просит ввести количество элементов (m) создаваемого массива (fullArr)
2. Создается массив fullArr с заполнением через подпрограмму GenMas(m)
3. Запускается подпрограмма GenMas(m):
- Запрашивается поочередно каждый элемент нового массива
- Возвращается сформированный массив
4. Вывод сообщения "Создаем массив с элементами короче 4-х символов..."
5. Создается массив cutArr с заполнением через подпрограмму CutMas(fullArr)
6. Запускается подпрограмма CutMas(fullArr):
- Проводится подсчет количества элементов (j) массива fullArr, длина которых меньше 4 символов
- Создается новый массив mas с длиной j
- В новый массив mas записываются элементы из массива fullArr, длинна которых меньше 4
- Возвращается сформированный массив mas
7. Вывод сформированного массива cutArr
