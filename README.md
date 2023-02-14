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

   7.3. Создал дополнительную ветвь Print, для работы над выводом массива строк на экран, далее перешел в неё и убедился, что переход осуществлен.
   >Команда: git checkout -b Print
   >Команда: git branch

   7.4. Открыл файл Program.cs и набрал код для метода PrintOfArray.
   7.5. Сохранил файл Program.cs и проверил работоспособность кода. Далее перенес изменения в индексируемую область и зафиксировал изменения репозитория.
   >Команда: dotnet run  
   >Команда: git add .  
   >Команда: git commit -m "Added method PrintOfArray to the file Programs.cs"

   7.6. Перешел из ветви Print обратно в ветвь master и убедился в том, что переход осуществлен.
   >Команда: git checkout master
   >Команда: git branch

   7.7. Осуществил слияние двух ветвей Print и master. Далее перенес изменения в индексируемую область и зафиксировал изменения репозитория.
   >Команда: git merge Print
   >Команда: git add .  
   >Команда: git commit -m "Merging two branches Print and master"

   7.8. Создал дополнительную ветвь Delete, для работы над удалением строк из массива с длиной более 3 символов, далее перешел в неё и убедился, что переход осуществлен.
   >Команда: git checkout -b Delete
   >Команда: git branch

   7.9. Открыл файл Program.cs и набрал код для метода DeletingLinesFromArray.
   7.10. Сохранил файл Program.cs и проверил работоспособность кода. Далее перенес изменения в индексируемую область и зафиксировал изменения репозитория.
   >Команда: dotnet run  
   >Команда: git add .  
   >Команда: git commit -m "Added method DeletingLinesFromArray to the file Programs.cs"

   7.11. Дополнил файл README.md и сохранил его. Далее перенес изменения в индексируемую область и зафиксировал изменения репозитория.
   >Команда: git add .  
   >Команда: git commit -m "Updates file README.md"

   7.12. Перешел из ветви Delete обратно в ветвь master и убедился в том, что переход осуществлен.
   >Команда: git checkout master
   >Команда: git branch

   7.13. Осуществил слияние двух ветвей Delete и master. Далее перенес изменения в индексируемую область и зафиксировал изменения репозитория.
   >Команда: git merge Print
   >Команда: git add .  
   >Команда: git commit -m "Merging two branches Delete and master"
8. 