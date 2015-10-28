using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InputBoxSharp
{
    public static class InputBoxSharpClass
    {
        /// <summary>
        /// Zeigt eine Eingabeaufforderung in einem Dialogfeld an, wartet auf die Eingabe eines Textes oder auf das Klicken auf eine Schaltfläche durch den Benutzer und gibt eine Zeichenfolge zurück, die den Inhalt des Textfelds angibt.
        /// </summary>
        /// <param name="Prompt">Als Meldung im Dialogfeld angezeigter String-Ausdruck. Die maximale Länge von Prompt beträgt ungefähr 1024 Zeichen, abhängig von der Breite der verwendeten Zeichen. Wenn Prompt aus mehreren Zeilen besteht, können Sie die Zeilen trennen, indem Sie jeweils ein Wagenrücklaufzeichen(Chr(13)), ein Zeilenvorschubzeichen(Chr(10)) oder eine Kombination aus Wagenrücklauf und Zeilenvorschub (Chr(13) & Chr(10)) zwischen jeder Zeile einfügen.</param>
        /// <returns></returns>
        public static string InputBox(string Prompt)
        {
            InputBoxSharp frm = new InputBoxSharp(Prompt, "", "");
            frm.ShowDialog();
            return frm.Response(); 
        }

        /// <summary>
        /// Zeigt eine Eingabeaufforderung in einem Dialogfeld an, wartet auf die Eingabe eines Textes oder auf das Klicken auf eine Schaltfläche durch den Benutzer und gibt eine Zeichenfolge zurück, die den Inhalt des Textfelds angibt.
        /// </summary>
        /// <param name="Prompt">Als Meldung im Dialogfeld angezeigter String-Ausdruck. Die maximale Länge von Prompt beträgt ungefähr 1024 Zeichen, abhängig von der Breite der verwendeten Zeichen. Wenn Prompt aus mehreren Zeilen besteht, können Sie die Zeilen trennen, indem Sie jeweils ein Wagenrücklaufzeichen(Chr(13)), ein Zeilenvorschubzeichen(Chr(10)) oder eine Kombination aus Wagenrücklauf und Zeilenvorschub (Chr(13) & Chr(10)) zwischen jeder Zeile einfügen.</param>
        /// <param name="Title">Auf der Titelleiste des Dialogfelds angezeigter String-Ausdruck. Wenn Die Title nicht angeben, wird der Anwendungsname auf der Titelleiste plaziert.</param>
        /// <returns></returns>
        public static string InputBox(string Prompt, string Title)
        {
            InputBoxSharp frm = new InputBoxSharp(Prompt, Title, "");
            frm.ShowDialog();
            return frm.Response(); 
        }

        /// <summary>
        /// Zeigt eine Eingabeaufforderung in einem Dialogfeld an, wartet auf die Eingabe eines Textes oder auf das Klicken auf eine Schaltfläche durch den Benutzer und gibt eine Zeichenfolge zurück, die den Inhalt des Textfelds angibt.
        /// </summary>
        /// <param name="Prompt">Als Meldung im Dialogfeld angezeigter String-Ausdruck. Die maximale Länge von Prompt beträgt ungefähr 1024 Zeichen, abhängig von der Breite der verwendeten Zeichen. Wenn Prompt aus mehreren Zeilen besteht, können Sie die Zeilen trennen, indem Sie jeweils ein Wagenrücklaufzeichen(Chr(13)), ein Zeilenvorschubzeichen(Chr(10)) oder eine Kombination aus Wagenrücklauf und Zeilenvorschub (Chr(13) & Chr(10)) zwischen jeder Zeile einfügen.</param>
        /// <param name="Title">Auf der Titelleiste des Dialogfelds angezeigter String-Ausdruck. Wenn Die Title nicht angeben, wird der Anwendungsname auf der Titelleiste plaziert.</param>
        /// <param name="DefaultResponse">String-Ausdruck, der im Textfeld standardmäßig angezeigt wird, wenn keine andere Eingabe erfolgt. Wenn Sie DefaultResponse nicht angeben, ist das angezeigte Textfeld leer.</param> 
        /// <returns></returns>
        public static string InputBox(string Prompt, string Title, string DefaultResponse)
        {
            InputBoxSharp frm = new InputBoxSharp(Prompt, Title, DefaultResponse);
            frm.ShowDialog();
            return frm.Response(); 
        }

        /// <summary>
        /// Zeigt eine Eingabeaufforderung in einem Dialogfeld an, wartet auf die Eingabe eines Textes oder auf das Klicken auf eine Schaltfläche durch den Benutzer und gibt eine Zeichenfolge zurück, die den Inhalt des Textfelds angibt.
        /// </summary>
        /// <param name="Prompt">Als Meldung im Dialogfeld angezeigter String-Ausdruck. Die maximale Länge von Prompt beträgt ungefähr 1024 Zeichen, abhängig von der Breite der verwendeten Zeichen. Wenn Prompt aus mehreren Zeilen besteht, können Sie die Zeilen trennen, indem Sie jeweils ein Wagenrücklaufzeichen(Chr(13)), ein Zeilenvorschubzeichen(Chr(10)) oder eine Kombination aus Wagenrücklauf und Zeilenvorschub (Chr(13) & Chr(10)) zwischen jeder Zeile einfügen.</param>
        /// <param name="Title">Auf der Titelleiste des Dialogfelds angezeigter String-Ausdruck. Wenn Die Title nicht angeben, wird der Anwendungsname auf der Titelleiste plaziert.</param>
        /// <param name="DefaultResponse">String-Ausdruck, der im Textfeld standardmäßig angezeigt wird, wenn keine andere Eingabe erfolgt. Wenn Sie DefaultResponse nicht angeben, ist das angezeigte Textfeld leer.</param> 
        /// <param name="passwordchar">Angabe, ob der im Textfeld enthaltende Text durch ein Passwordchar versteckt werden soll.</param>
        /// <returns></returns>
        public static string InputBox(string Prompt, string Title, string DefaultResponse, bool passwordchar)
        {
            InputBoxSharp frm = new InputBoxSharp(Prompt, Title, DefaultResponse, passwordchar);
            frm.ShowDialog();
            return frm.Response();
        }
    }
}
