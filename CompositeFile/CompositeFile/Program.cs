using CompositeFile;

class Program
{
    static void Main()
    {
        Document document1 = new Document("Документ 1");

        Section section1 = new Section("Раздел 1: ЗАДАЧА");
        section1.Add(new Paragraph("Задание: ВЫЖМИТЬ"));
        section1.Add(new Paragraph("Инструкция: САПТЬ"));

        Section subsection1 = new Section("Подраздел 1.1: Вложенный раздел");
        subsection1.Add(new Paragraph("Вложенный параграф: Работай усердно"));
        section1.Add(subsection1);

        document1.Add(section1);

        Paragraph incorrectParagraph = new Paragraph("Некорректное добавление");
        incorrectParagraph.Add(section1);

        Document document2 = new Document("Документ 2");

        Section section2 = new Section("Раздел 2: ИНФОРМАЦИЯ");
        section2.Add(new Paragraph("Текст: Образец текста для тестирования"));

        Section subsection2 = new Section("Подраздел 2.1: Дополнительные данные");
        subsection2.Add(new Paragraph("Дополнительный параграф в подразделе"));

        Section deepSection = new Section("Глубокая вложенность");
        Section nestedSection = new Section("Очень глубокий уровень");
        nestedSection.Add(new Paragraph("Глубоко вложенный параграф"));
        deepSection.Add(nestedSection);
        subsection2.Add(deepSection);

        section2.Add(subsection2);
        document2.Add(section2);

        document1.Display();
        document2.Display();

        document1.Remove(section1);

        Console.WriteLine("\nСодержимое документа 1 после удаления раздела:");
        document1.Display();
    }
}
