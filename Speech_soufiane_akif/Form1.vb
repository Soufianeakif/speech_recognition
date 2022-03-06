Imports System.Speech
'Follow me on tiktok and instagram @soufiane___akif ;)
'TIKTOK :
'https://www.tiktok.com/@soufiane__akif
'INSTAGRAM :
'https://www.instagram.com/soufiane__akif
Public Class Form1

    Dim WithEvents Myvoice As New Recognition.SpeechRecognitionEngine


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyVoice.SetInputToDefaultAudioDevice()


        Dim MyGrammar As New Recognition.SrgsGrammar.SrgsDocument


        Dim MyWordsRule As New Recognition.SrgsGrammar.SrgsRule("words")


        Dim MyWords As New Recognition.SrgsGrammar.SrgsOneOf("zwina", "Salut", "spotify", "heure")


        MyWordsRule.Add(MyWords)


        MyGrammar.Rules.Add(MyWordsRule)

        MyGrammar.Root = MyWordsRule


        MyVoice.LoadGrammar(New Recognition.Grammar(MyGrammar))

        MyVoice.RecognizeAsync()

    End Sub

    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles Myvoice.RecognizeCompleted

        Myvoice.RecognizeAsync()




    End Sub
    Dim SAPI

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles Myvoice.SpeechRecognized
        SAPI = CreateObject("SAPI.spvoice")

        Select Case e.Result.Text
            'if the user speaks "simo"
            Case "zwina"
                SAPI.Speak("Oui monsieur")
                lbl1.Text = "Oui monsieur"

            Case "Salut"
                SAPI.Speak("Salut soufiane")
                lbl1.Text = "Salut soufiane"

            Case "spotify"
                'open spotify
                SAPI.Speak("oui bien sur")
                Shell("spotify")
                lbl1.Text = "Enjoy sir ;)"

            Case "heure"
                'l'heure
                SAPI.Speak("L'heure est " + Date.Now.ToString("hh:mm"))
                lbl1.Text = "Heure est " + Date.Now.ToString("hh:mm")


        End Select

    End Sub

End Class
