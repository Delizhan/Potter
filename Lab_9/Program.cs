using Lab_9;
using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Faculty facultyGr = new Faculty(NameFaculty.gryffindor, Animal.lion);
Faculty facultyHuff = new Faculty(NameFaculty.hufflepuff, Animal.badger);
Faculty facultyRaven = new Faculty(NameFaculty.ravenclaw, Animal.eagle);
Faculty facultySl = new Faculty(NameFaculty.slytherin, Animal.snake);
int menu;
do
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("**************КВІДИЧ***************");
    Console.ResetColor();
    Console.WriteLine("1 - створити команду;");
    Console.WriteLine("2 - вивести на екран склад команд;");
    Console.WriteLine("3 - почати гру;");
    Console.WriteLine("0 - вийти з програми.");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("***********************************");
    Console.ResetColor();
    Console.Write("Введіть цифру --> ");
    menu = InputInt((value) => (value >= 0) && (value <= 3), "Число має бути в діапазоні від 0 до 3.");
    Console.WriteLine();
    switch (menu)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Дані про факультет:");
            Console.ResetColor();
            Console.WriteLine("1 - Грифіндор;");
            Console.WriteLine("2 - Пуффендуй;");
            Console.WriteLine("3 - Когтевран;");
            Console.WriteLine("4 - Слизерин.");
            Console.Write("Введіть назву факультета, до якого хочете додати команду --> ");
            int nameFaculty = InputInt((value) => (value >= 0) && (value <= 3), "Число має бути в діапазоні від 0 до 4.");
            if (nameFaculty == 1)
                Add(facultyGr.teams, 0, 0);
            else if (nameFaculty == 2)
                Add(facultyHuff.teams, 0, 0);
            else if (nameFaculty == 3)
                Add(facultyRaven.teams, 0, 0);
            else if (nameFaculty == 4)
                Add(facultySl.teams, 0, 0);
            break;
        case 2:
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            if (facultyGr.teams.Count != 0)
            {
                Console.Write("Факультет: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Грифіндор");
                Console.ResetColor();
                Console.WriteLine(facultyGr.Description);
                Console.WriteLine("Тварина: " + facultyGr.Animal);
                Print(facultyGr);
            }
            else
            {
                Console.Write("Факультет ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\"Грифіндор\" ");
                Console.ResetColor();
                Console.WriteLine("не має команд.");
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            if (facultyHuff.teams.Count != 0)
            {
                Console.Write("Факультет: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Пуффендуй");
                Console.ResetColor();
                Console.WriteLine(facultyHuff.Description);
                Console.WriteLine("Тварина: " + facultyHuff.Animal);
                Print(facultyHuff);
            }
            else
            {
                Console.Write("Факультет ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\"Пуффендуй\" ");
                Console.ResetColor();
                Console.WriteLine("не має команд.");
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            if (facultyRaven.teams.Count != 0)
            {
                Console.Write("Факультет: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Когтевран");
                Console.ResetColor();
                Console.WriteLine(facultyRaven.Description);
                Console.WriteLine("Тварина: " + facultyRaven.Animal);
                Print(facultyRaven);
            }
            else
            {
                Console.Write("Факультет ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\"Когтевран\" ");
                Console.ResetColor();
                Console.WriteLine("не має команд.");
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            if (facultySl.teams.Count != 0)
            {
                Console.Write("Факультет: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Слизерин");
                Console.ResetColor();
                Console.WriteLine(facultySl.Description);
                Console.WriteLine("Тварина: " + facultySl.Animal);
                Print(facultySl);
            }
            else
            {
                Console.Write("Факультет ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\"Слизерин\" ");
                Console.ResetColor();
                Console.WriteLine("не має команд.");
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            break;
        case 3:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Правила гри:");
            Console.ResetColor();
            Console.WriteLine("Змагається дві команди. Команда, яка має більше голів, змагається з наступною. Та команда, яка має найбільшу кількість\nголів серед усіх інших команд, виграє та вважається переможцем. Переможців може бути декілька, вони отримують кубок.");
            Console.WriteLine();
            if (facultyGr.teams.Count != 0)
            {
                Console.WriteLine("Введіть кількість голів для кожної команди факультету.");
                Console.Write("Факультет: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Грифіндор");
                Console.ResetColor();
                DefineGoals(facultyGr);
                StartGame(facultyGr);
            }
            else
            {
                Console.Write("Факультет ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\"Грифіндор\" ");
                Console.ResetColor();
                Console.WriteLine("не має команд.");
            }
            Console.WriteLine();
            if (facultyHuff.teams.Count != 0)
            {
                Console.Write("Факультет: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Пуффендуй");
                Console.ResetColor();
                DefineGoals(facultyHuff);
                StartGame(facultyHuff);
            }
            else
            {
                Console.Write("Факультет ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\"Пуффендуй\" ");
                Console.ResetColor();
                Console.WriteLine("не має команд.");
            }
            Console.WriteLine();
            if (facultyRaven.teams.Count != 0)
            {
                Console.Write("Факультет: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Когтевран");
                Console.ResetColor();
                DefineGoals(facultyRaven);
                StartGame(facultyRaven);
            }
            else
            {
                Console.Write("Факультет ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\"Когтевран\" ");
                Console.ResetColor();
                Console.WriteLine("не має команд.");
            }
            Console.WriteLine();
            if (facultySl.teams.Count != 0)
            {
                Console.Write("Факультет: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Слизерин");
                Console.ResetColor();
                DefineGoals(facultySl);
                StartGame(facultySl);
            }
            else
            {
                Console.Write("Факультет ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\"Слизерин\" ");
                Console.ResetColor();
                Console.WriteLine("не має команд.");
            }
            Console.WriteLine();
            break;
        case 0: break;
        default:
            Console.WriteLine("Ви неправильно ввели цифру.");
            break;
    }
} while (menu != 0);

static int InputInt(Func<int, bool> condition, string errortext)
{
    int value;

    while (!int.TryParse(Console.ReadLine(), out value) || !condition(value))
    {
        Console.WriteLine(errortext);
        Console.Write("Спробуйте ще раз: ");
    }
    return value;
}
static string InputStr(Func<string, bool> condition, string errortext)
{
    string? value;
    while (true)
    {
        value = Console.ReadLine();

        if (condition(value))
            break;

        Console.WriteLine(errortext);
        Console.Write("Спробуйте ще раз: ");
    }
    return value;
}
static void Add(List<Team> teams, int kolB, int kolR)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Дані про команду:");
    Console.ResetColor();
    Console.Write("Введіть назву команди --> ");
    string nameTeam = InputStr(input => !string.IsNullOrEmpty(input), "Помилка: пустий рядок.");
    Console.Write("Введіть рік заснування команди --> ");
    int founded = InputInt(value => (value >= 1000) && (value <= 2022), "Число має бути в діапазоні від 1000 до 2022.");
    Console.Write("Введіть колір форми команди --> ");
    string colorForm = InputStr(input => !string.IsNullOrEmpty(input), "Помилка: пустий рядок.");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Дані про тренера:");
    Console.ResetColor();
    Console.Write("Введіть ім'я тренера --> ");
    string firstNameTrener = InputStr(input => !string.IsNullOrEmpty(input), "Помилка: пустий рядок.");
    Console.Write("Введіть прізвище тренера --> ");
    string lastNameTrener = InputStr(input => !string.IsNullOrEmpty(input), "Помилка: пустий рядок.");
    Console.Write("Введіть вік тренера --> ");
    int ageTrener = InputInt((value) => (value > 0), "Число має бути більше 0.");
    
    Coach coach = new Coach(ageTrener, firstNameTrener, lastNameTrener);
    Team team = new Team(founded, nameTeam, colorForm, 0, 0, coach);

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Дані про мітлу:");
    Console.ResetColor();
    Broom broom = new NimbysBroom();
    Console.WriteLine(broom.DescriptionBrooms);
    Console.WriteLine($"Введіть номер моделі мітли, яку буде використовувати команда:");
    Console.WriteLine("1 - \"Німбус-2001\", 2 - \"Блискавка\".");
    Console.Write("--> ");
    int model = InputInt(value => (value >= 1) && (value <= 2), "Число має бути в діапазоні від 1 до 2.");
    if (model == 1)
        team.Broom = new NimbysBroom();
    else
        team.Broom = new LightningBroom();
    Console.WriteLine(team.Broom.Fly());

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Дані про гравців:");
    Console.ResetColor();
    Console.Write("Введіть кількість гравців (від 5 до 7) --> ");
    int kolPlayers = InputInt(value => value >= 5 && value <= 7, "Число має бути в діапазоні від 5 до 7.");
    Console.WriteLine();
    Position position = Position.catcher;
    int menu;
    if (kolPlayers == 7)
    {
        Console.WriteLine("Кількість гравців на кожній позиції:");
        Console.WriteLine("2 - загонич;");
        Console.WriteLine("1 - воротар;");
        Console.WriteLine("2 - відбивач;");
        Console.WriteLine("1 - ловець;");
        Console.WriteLine("1 - капітан.");
        Console.WriteLine();
        for (int i = 0; i < kolPlayers; i++)
        {
            Console.Write($"Введіть ім'я гравця №{i + 1} --> ");
            string firstNamePlayer = InputStr(input => !string.IsNullOrEmpty(input), "Помилка: пустий рядок.");
            Console.Write($"Введіть прізвище гравця №{i + 1} --> ");
            string lastNamePlayer = InputStr(input => !string.IsNullOrEmpty(input), "Помилка: пустий рядок.");
            Console.Write($"Введіть вік гравця №{i + 1} --> ");
            int agePlayer = InputInt(value => value > 0, "Число має бути більше 0.");
            Console.WriteLine($"Введіть позицію гравця №{i + 1}:");
            do
            {
                Console.WriteLine("1 - загонич, 2 - відбивач, 3 - воротар, 4 - ловець, 5 - капітан.");
                Console.Write("--> ");
                menu = InputInt((value) => (value >= 1) && (value <= 5), "Число має бути в діапазоні від 1 до 5.");
                if (menu == 1)
                {
                    position = Position.beater;
                    kolB++;
                }
                if (menu == 2)
                {
                    position = Position.reflector;
                    kolR++;
                }
                if (menu == 3)
                {
                    position = Position.goalkeeper;
                }
                if (menu == 4)
                {
                    position = Position.catcher;
                }
                if (menu == 5)
                {
                    position = Position.captain;
                }
            } while ((kolB > 2 && menu == 1) || (kolR > 2 && menu == 2) || (team.players.Exists(p => p.Position == position) && position != Position.beater && position != Position.reflector));

            Player player = new Player(agePlayer, firstNamePlayer, lastNamePlayer, position);
            team.players.Add(player);
            Console.WriteLine();
        }
    }
    else if (kolPlayers == 6)
    {
        Console.WriteLine("Кількість гравців на кожній позиції:");
        Console.WriteLine("1/2 - загонич;");
        Console.WriteLine("1 - воротар;");
        Console.WriteLine("1/2 - відбивач;");
        Console.WriteLine("1 - ловець;");
        Console.WriteLine("1 - капітан.");
        Console.WriteLine();
        for (int i = 0; i < kolPlayers; i++)
        {
            Console.Write($"Введіть ім'я гравця №{i + 1} --> ");
            string firstNamePlayer = InputStr(input => !string.IsNullOrEmpty(input), "Помилка: пустий рядок.");
            Console.Write($"Введіть прізвище гравця №{i + 1} --> ");
            string lastNamePlayer = InputStr(input => !string.IsNullOrEmpty(input), "Помилка: пустий рядок.");
            Console.Write($"Введіть вік гравця №{i + 1} --> ");
            int agePlayer = InputInt(value => value > 0, "Число має бути більше 0.");
            Console.WriteLine($"Введіть позицію гравця №{i + 1}:");
            do
            {
                Console.WriteLine("1 - загонич, 2 - відбивач, 3 - воротар, 4 - ловець, 5 - капітан.");
                Console.Write("--> ");
                menu = InputInt((value) => (value >= 1) && (value <= 5), "Число має бути в діапазоні від 1 до 5.");
                if (menu == 1)
                {
                    position = Position.beater;
                    kolB++;
                }
                if (menu == 2)
                {
                    position = Position.reflector;
                    kolR++;
                }
                if (menu == 3)
                {
                    position = Position.goalkeeper;
                }
                if (menu == 4)
                {
                    position = Position.catcher;
                }
                if (menu == 5)
                {
                    position = Position.captain;
                }
            } while ((kolB >= 2 && menu == 1 && kolR >= 2) || (kolR >= 2 && menu == 2 && kolB >= 2) || (kolB > 2 && menu == 1) || (kolR > 2 && menu == 2) || (team.players.Exists(p => p.Position == position) && position != Position.beater && position != Position.reflector));

            Player player = new Player(agePlayer, firstNamePlayer, lastNamePlayer, position);
            team.players.Add(player);
            Console.WriteLine();
        }
    }
    else if (kolPlayers == 5)
    {
        Console.WriteLine("Кількість гравців на кожній позиції:");
        Console.WriteLine("1 - загонич;");
        Console.WriteLine("1 - воротар;");
        Console.WriteLine("1 - відбивач;");
        Console.WriteLine("1 - ловець;");
        Console.WriteLine("1 - капітан.");
        Console.WriteLine();
        for (int i = 0; i < kolPlayers; i++)
        {
            Console.Write($"Введіть ім'я гравця №{i + 1} --> ");
            string firstNamePlayer = InputStr(input => !string.IsNullOrEmpty(input), "Помилка: пустий рядок.");
            Console.Write($"Введіть прізвище гравця №{i + 1} --> ");
            string lastNamePlayer = InputStr(input => !string.IsNullOrEmpty(input), "Помилка: пустий рядок.");
            Console.Write($"Введіть вік гравця №{i + 1} --> ");
            int agePlayer = InputInt(value => value > 0, "Число має бути більше 0.");
            Console.WriteLine($"Введіть позицію гравця №{i + 1}:");
            do
            {
                Console.WriteLine("1 - загонич, 2 - відбивач, 3 - воротар, 4 - ловець, 5 - капітан.");
                Console.Write("--> ");
                menu = InputInt((value) => (value >= 1) && (value <= 5), "Число має бути в діапазоні від 1 до 5.");
                if (menu == 1)
                {
                    position = Position.beater;
                }
                if (menu == 2)
                {
                    position = Position.reflector;
                }
                if (menu == 3)
                {
                    position = Position.goalkeeper;
                }
                if (menu == 4)
                {
                    position = Position.catcher;
                }
                if (menu == 5)
                {
                    position = Position.captain;
                }
            } while (team.players.Exists(p => p.Position == position));

            Player player = new Player(agePlayer, firstNamePlayer, lastNamePlayer, position);
            team.players.Add(player);
            Console.WriteLine();
        }
    }
    teams.Add(team);
    Console.WriteLine($"Команду \"{team.Name}\" створено.");
    Console.WriteLine();
}
static void Print(Faculty faculty)
{
    for (int i = 0; i < faculty.teams.Count; i++)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Команда \"{faculty.teams[i].Name}\":");
        Console.ResetColor();
        Console.Write($"Назва: {faculty.teams[i].Name}\t");
        Console.Write($"Рік заснування: {faculty.teams[i].Founded}\t");
        Console.Write($"Колір форми: {faculty.teams[i].ColorForm}\t");
        Console.Write($"Кількість голів: {faculty.teams[i].Goal}\t");
        Console.Write($"Кількість кубків: {faculty.teams[i].Cup}\t");
        Console.Write($"Сума галеон: {faculty.teams[i].Balance}\t");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Мітла:");
        Console.Write($"Модель: {faculty.teams[i].Broom.Model}\t");
        Console.Write($"Швидкість (миль/год.): {faculty.teams[i].Broom.Speed}\t");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Тренер:");
        Console.Write($"Ім'я тренера: {faculty.teams[i].Coach.FirstName}\t");
        Console.Write($"Прізвище тренера: {faculty.teams[i].Coach.LastName}\t");
        Console.Write($"Вік тренера: {faculty.teams[i].Coach.Age}\t");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Гравці:");
        for (int j = 0; j < faculty.teams[i].players.Count; j++)
        {
            Console.Write($"Ім'я гравця №{j + 1}: {faculty.teams[i].players[j].FirstName}\t");
            Console.Write($"Прізвище гравця №{j + 1}: {faculty.teams[i].players[j].LastName}\t");
            Console.Write($"Вік гравця №{j + 1}: {faculty.teams[i].players[j].Age}\t");
            Console.Write($"Позиція гравця №{j + 1}: {faculty.teams[i].players[j].Position}\t");
            Console.WriteLine();
        }
        if (i != faculty.teams.Count - 1)
            Console.WriteLine();
    }
}
static void DefineGoals(Faculty faculty)
{
    int goals;
    for(int i = 0; i < faculty.teams.Count; i++)
    {
        Console.Write($"Команда \"{faculty.teams[i].Name}\" --> ");
        goals = InputInt((value) => (value > 0), "Число має бути більше за 0.");
        faculty.teams[i].Goal = goals;
    }
    Game game = new Game(faculty.teams[0], faculty.teams[0]);
    game.OnReadinessToGame += PrintMessage;
    game.StartGame(faculty);
}
static void StartGame(Faculty faculty)
{
    Console.WriteLine();
    Game game;
    Team? teamWin = null;
    List<Team?> teamsDop = new List<Team?>();
    if (faculty.teams.Count != 1)
    {
        if (faculty.teams.Count == 2)
        {
            if (faculty.teams[0].Goal == faculty.teams[1].Goal)
            {
                Console.WriteLine($"Виграла команда \"{faculty.teams[0].Name}\".");
                faculty.teams[0].Cup++;
                DoOperation(faculty.teams[0], AddBalance);
                Console.WriteLine($"Виграла команда \"{faculty.teams[1].Name}\".");
                faculty.teams[1].Cup++;
                DoOperation(faculty.teams[1], AddBalance);
                game = new Game(faculty.teams[0], faculty.teams[0]);
                game.OnFinish += PrintMessage;
                game.FinishGame(faculty.teams[0]);
                game.FinishGame(faculty.teams[1]);
            }
            else
            {
                game = new Game(faculty.teams[0], faculty.teams[1]);
                teamWin = game.DefineWinner(faculty.teams[0], faculty.teams[1]);
                Console.WriteLine($"Виграла команда \"{teamWin.Name}\".");
                teamWin.Cup++;
                DoOperation(teamWin, AddBalance);
                game.OnFinish += PrintMessage;
                game.FinishGame(teamWin);
            }
            faculty.teams[0].Goal = 0;
            faculty.teams[1].Goal = 0;
        }
        else if (faculty.teams.Count > 2)
        {
            if (faculty.teams[0].Goal != faculty.teams[1].Goal)
            {
                game = new Game(faculty.teams[0], faculty.teams[1]);
                teamWin = game.DefineWinner(faculty.teams[0], faculty.teams[1]);
            }
            else
            {
                teamsDop.Add(faculty.teams[1]);
                teamWin = faculty.teams[0];
            }
            for (int i = 2; i < faculty.teams.Count; i++)
            {
                if (faculty.teams[i].Goal != teamWin.Goal)
                {
                    game = new Game(faculty.teams[i], teamWin);
                    teamWin = game.DefineWinner(faculty.teams[i], teamWin);
                }
                else
                    teamsDop.Add(faculty.teams[i]);
            }
            game = new Game(faculty.teams[0], faculty.teams[0]);
            if (teamsDop.Count != 0)
            {
                int max = teamWin.Goal;
                for (int i = 0; i < teamsDop.Count; i++)
                {
                    if (max < teamsDop[i].Goal)
                        max = teamsDop[i].Goal;
                }
                if(teamWin.Goal == max)
                {
                    Console.WriteLine($"Виграла команда \"{teamWin.Name}\".");
                    teamWin.Cup++;
                    DoOperation(teamWin, AddBalance);
                    teamWin.Goal = 0;
                    game.OnFinish += PrintMessage;
                    game.FinishGame(teamWin);
                }
                for (int i = 0; i < teamsDop.Count; i++)
                {
                    if (max == teamsDop[i].Goal)
                    {
                        teamWin = teamsDop[i];
                        Console.WriteLine($"Виграла команда \"{teamsDop[i].Name}\".");
                        teamsDop[i].Cup++;
                        DoOperation(teamsDop[i], AddBalance);
                        game.OnFinish += PrintMessage;
                        game.FinishGame(teamsDop[i]);
                    }
                    teamsDop[i].Goal = 0;
                }
            }
            else
            {
                Console.WriteLine($"Виграла команда \"{teamWin.Name}\".");
                teamWin.Cup++;
                DoOperation(teamWin, AddBalance);
                for (int i = 0; i < faculty.teams.Count; i++)
                    faculty.teams[i].Goal = 0;
                game.OnFinish += PrintMessage;
                game.FinishGame(teamWin);
            }
        }
    }
    else
    {
        Console.WriteLine($"Виграла команда \"{faculty.teams[0].Name}\".");
        faculty.teams[0].Goal = 0;
        faculty.teams[0].Cup++;
        DoOperation(faculty.teams[0], AddBalance);
        game = new Game(faculty.teams[0], faculty.teams[0]);
        game.OnFinish += PrintMessage;
        game.FinishGame(faculty.teams[0]);
    }
}
static void AddBalance(Team team) => team.Balance += 100;
static void DoOperation(Team team, Action<Team> action) => action(team);
static void PrintMessage(string message) => Console.WriteLine(message);