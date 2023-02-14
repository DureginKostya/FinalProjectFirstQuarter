# Выполненная работа

1. Проверил существует или нет репозиторий в папке FirstProjectFirstQuarter.
   >Команда: git status
2. Инициализировал репозиторий.
   >Команда: git init
3. Создал пустой текстовый файл README.md, в котором будет описание выполненных работ и кода проекта.
   >Команда: touch README.md
4. Открыл файл README.md, внес изменения в него и сохранил. Далее:
   * Перенес изменения в индексируемую область.
   >Команда: git add README.md
   * Зафиксировал изменения.
   >Команда: git commit -m "File created README.md with description"
5. Создал файл .gitignore зафиксировал изменения в репозитории.
   >Команда: dotnet new gitignore  
   >Команда: git add .  
   >Команда: git commit -m "File added .gitignore"
6. Создал папку Task и перешел в неё. Далее в этой папке создал проект с использованием языка программирования C#. Далее перенес изменения в индексируемую область и зафиксировал изменения репозитория.
   * Создание папки Task.
   >Команда: mkdir Task
   * Переход в папку Task.
   >Команда: cd Task
   * Создание проекта.
   >Команда: dotnet new console
   * Перенес изменения в индексируемую область.
   >Команда: git add .
   * Зафиксировал изменения.
   >Команда: git commit -m "Folder created Task and project created Task.csproj"
7. Работа с проектом Task.csproj:

   7.1. Открыл файл Programs.cs и набрал код для трех методов:
   * GetNumberOfLines;
   * GetLinesFromUser;
   * ColorizeText.

   7.2. Сохранил файл Programs.cs и проверил работоспособность кода. Далее перенес изменения в индексируемую область и зафиксировал изменения репозитория.
   >Команда: dotnet run  
   >Команда: git add .  
   >Команда: git commit -m "Added methods GetNumberOfLines, GetLinesFromUser and ColorizeText to the file Programs.cs"
8. 