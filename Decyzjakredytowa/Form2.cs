using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecyzjaKredytowa
{
    public partial class Form2 : Form
    {
        private readonly string[] _questions = new string[10];//inicjalizacja tablicy zawierającej zestaw pytań
        private readonly string[] _hints = new string[10]; //inicijalizacja tablicy zawierającej wskazówki dla użytkownika
        List<Panel> _panels = new List<Panel>(); //utworzenie listy paneli zawierających możliwe odpowiedzi
        private int _whichQuestion = 0; //licznik pytań, zaczynamy zadawanie od pierszego elementu tablicy
        private static string _info = "Hello";
        private static bool _canContinue = true;

        public static string GetInfo()
        {
            return _info;
        }
        
        //konstruktor drugiego okna
        public Form2()
        {
            InitializeComponent();
            //wypełniamy tablicę pytań
            _questions[0] = "Czy masz ukończone 18 lat?";
            _questions[1] = "Czy Twoje zarobki przekraczają 2000 zł netto miesięcznie?";
            _questions[2] = "Czy pracujesz na etat?";
            _questions[3] = "Czy masz umowę na czas nieokreślony";
            _questions[4] = "Czy umowa zawarta jest na okres min. 6 miesięcy (od tego czasu)?";
            _questions[5] = "Czy prowadzisz działalność gospodarczą?";
            _questions[6] = "Czy działalność jest prowadzona na terenie Polski?";
            _questions[7] = "Czy okres prowadzenia działalności jest dłuższy niż 12 miesięcy?";
            _questions[8] = "Czy kredytobiorca posiada historię kredytową";
            _questions[9] = "Czy historia kredytowa jest pozytywna?";
            //wypełniamy tablicę wskazówek
            _hints[0] = "Zaznacz 'Tak', jeśli masz minimum 18 lat.";
            _hints[1] = "Wysokość wynagrodzenia ma istotny wpływ na zdolnosć kredytową i komfort życia. Jesli Twoje dochody są niższe zaznacz 'nie' ";
            _hints[2] = "Stałe źródło dochodów jest podstawowym warunkiem udzielenia kredytu hipotecznego";
            _hints[3] = "Zaznacz 'Tak' jeśli posiadasz taką umowę.";
            _hints[4] = "Minimalny czas trwania umowy dotychczas musi wynosić 6 miesięcy";
            _hints[5] = "Minimalny czas na który zawarta jest umowa musi być większy niż 6 miesięcy (od dnia dzisiejszego)";
            _hints[6] = "Jeżeli działalność gospodarcza, którą prowadzisz jest na zarejestrowana na terenie Polski zaznacz 'tak'";
            _hints[7] = "Minimalny czas prowadzenia działalności gospodarczej na terenie Polski wynosi 12 miesiecy";
            _hints[8] = "Historia kredytowa oznacza zaciagane wczesniej kredyty, pożyczki";
            _hints[9] = "Pozytywna historia kredytowa mozliwa jest do sprawdzenia w BIKu";
            
            textBox1.Text = _questions[_whichQuestion]; //wyświetl pytanie zgodne z licznikiem pytań
            textBox2.Text = _hints[_whichQuestion]; //wyświetl wskazówkę zgodną z licznikem wskazówek
            //wypełnij listę paneli panelami zawierającymi checkBoxy z możliwymi odpowiedziami
            _panels.Add(pnlAnswersQuestion0);
            _panels.Add(pnlAnswersQuestion1);
            _panels.Add(pnlAnswersQuestion2);
            _panels.Add(pnlAnswersQuestion3);
            _panels.Add(pnlAnswersQuestion4);
            _panels.Add(pnlAnswersQuestion5);
            _panels.Add(pnlAnswersQuestion6);
            _panels.Add(pnlAnswersQuestion7);
            _panels.Add(pnlAnswersQuestion8);
            _panels.Add(pnlAnswersQuestion9);
            SetAnswers();
        }

        public void SetQuestion() //wyświetl dane pytanie
        {
            textBox1.Text = _questions[_whichQuestion];
        }

        public void SetHint() //wyświetl wskazówkę do danego pytania
        {
            textBox2.Text = _hints[_whichQuestion];
        }

        public void SetAnswers() //wyświetl panel z odpowiedzami do danego pytania
        {
            foreach (var panel in _panels) //ukryj wszystkie panele
            {
                panel.Visible = false;
            }
            _panels[_whichQuestion].Visible = true; //pokaż odpowiedni panel
        }
        //metoda obsługująca kliknięcie przycisku "dalej", po kliknięciu wyświetl następne pytanie, lub rozpocznij wnioskowanie
        //jeśli użytkownik odpowiedział na wszystkie pytania
        private void button1_Click(object sender, EventArgs e)
        {
            CheckIfUserAnswered();
            CheckIfUserCanContinue();
            SkipQuestion();
            if (_whichQuestion < 9 && _canContinue)
            {

                _whichQuestion++;
                SetQuestion();
                SetHint();
                SetAnswers();
            }
            else
            {
                button1.Text = "Zakończ ankietę";
                CheckAnswers();
                ShowSummary();
            }
        }

        private void SkipQuestion()
        {
            if (_whichQuestion==2 && boxIfHasEtatNo.Checked)
            {
                _whichQuestion = 4;
            }
            if (_whichQuestion == 3 && boxIfHasUmowaYes.Checked == true)
            {
                _whichQuestion = 7;
            }
            if (_whichQuestion == 4 && boxIfHasOkresYes.Checked == true)
            {
                _whichQuestion = 7;
            }
        }
        //metoda sprawdzająca odpowiedzi na pytania i stwierdzająca zdolność kredytową
        private void CheckAnswers()
        {
            textBox1.Text = "Zakończono ankietę, czekaj na wynik wnioskowania";
           
            if (boxHaveHistoriaNo.Checked)
            {
                _info =
                    "Mała zdolność kredytowa. Należy spróbować zaciągnąć mniejsze kredyty, ew. używać karty kredytowej.";
            }
            if (boxIfHasUmowaNo.Checked == false)
            {
                _info =
                    "   Mała zdolność kredytowa. Należy spróbować zaciągnąć mniejsze kredyty, ew. używać karty kredytowej.";
            }
            if (boxIfTooYoung.Checked == true)
            {
                _info = "Nie dostaniesz kredytu, bo masz za mało lat";
            }
            if (boxIfOldEnough.Checked == true && boxSalaryBelow.Checked == true)
            {
                _info = "Nie dostaniesz kredytu, bo masz za małe zarobki";
            }
            if (boxHistoriaPozytywnaNo.Checked == true)
            {
                _info = "Na 100% bank nie udzieli kredytu. Nie jesteś dla niego wiarygodny.";
            }
            if (boxHistoriaPozytywnaYes.Checked == true)
            {
                _info = "Super. Możesz starać się o pożyczkę";
            }
            if (boxIfHasOkresNo.Checked)
            {
                _info =
                    "Nie dostaniesz kredytu, bo taka umowa nie zapewnia bezpieczeństwa finansowego. Należy zorganizować promesę zatrudnienia.";
            }
            if (boxIfHasDzialalnoscNo.Checked)
            {
                _info =
                    "Inne umowy nie mogą być brane pod uwagę przy udzielaniu kredytu hipotecznego. Brak zdolności kredytowej.";
            }
            if (boxIfDzialalnoscPolskaNo.Checked)
            {
                _info = "Nie można udzielić kredytu dla osoby prowadzącej działalność poza terytorium Rzeczypospolitej";
            }
            if (boxIfOkresDluzszyNo.Checked)
            {
                _info =
                    "Mała zdolność kredytowa, firma musi być prowadzona min. 12 miesięcy. Przyjdź za kilka miesięcy.";
            }
        }
        
        private void boxIfTakenYes_CheckedChanged(object sender, EventArgs e)
        {
            if (boxIfOldEnough.Checked == true) boxIfTooYoung.Checked=false;
        }

        private void boxIfTakenNo_CheckedChanged(object sender, EventArgs e)
        {
            if (boxIfTooYoung.Checked == true) boxIfOldEnough.Checked = false;
        }

        private void boxTravelByAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSalaryAbove.Checked == true) boxSalaryBelow.Checked = false;
        }

        private void boxTravelByPublic_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSalaryBelow.Checked == true) boxSalaryAbove.Checked = false;
        }

        private void boxIfUseYes_CheckedChanged(object sender, EventArgs e)
        {
            if (boxIfHasEtatYes.Checked == true) boxIfHasEtatNo.Checked = false;
        }

        private void boxIfUseNo_CheckedChanged(object sender, EventArgs e)
        {
            if (boxIfHasEtatNo.Checked == true) boxIfHasEtatYes.Checked = false;
        }

        private void boxIfGraphicYes_CheckedChanged(object sender, EventArgs e)
        {
            if (boxIfHasUmowaYes.Checked == true) boxIfHasUmowaNo.Checked = false;
        }

        private void boxIfGraphicNo_CheckedChanged(object sender, EventArgs e)
        {
            if(boxIfHasUmowaNo.Checked == true) boxIfHasUmowaYes.Checked = false;
        }

        private void boxIfGraphicJobYes_CheckedChanged(object sender, EventArgs e)
        {
            if (boxIfHasOkresYes.Checked == true) boxIfHasOkresNo.Checked = false;
        }

        private void boxIfGraphicJobNo_CheckedChanged(object sender, EventArgs e)
        {
            if (boxIfHasOkresNo.Checked == true) boxIfHasOkresYes.Checked = false;
        }

        private void boxIfDesignerYes_CheckedChanged(object sender, EventArgs e)
        {
            if (boxIfHasDzialalnoscYes.Checked == true) boxIfHasDzialalnoscNo.Checked = false;
        }

        private void boxIfDesignerNo_CheckedChanged(object sender, EventArgs e)
        {
            if (boxIfHasDzialalnoscNo.Checked == true) boxIfHasDzialalnoscYes.Checked = false;
        }

        private void boxIfDesignerJobYes_CheckedChanged(object sender, EventArgs e)
        {
            if (boxIfDzialalnoscPolskaYes.Checked == true) boxIfDzialalnoscPolskaNo.Checked = false;
        }

        private void boxIfDesignerJobNo_CheckedChanged(object sender, EventArgs e)
        {
            if (boxIfDzialalnoscPolskaNo.Checked == true) boxIfDzialalnoscPolskaYes.Checked = false;
        }

        private void boxIfPlayerYes_CheckedChanged(object sender, EventArgs e)
        {
            if (boxIfOkresDluzszyYes.Checked == true) boxIfOkresDluzszyNo.Checked = false;
        }

        private void boxIfPlayerNo_CheckedChanged(object sender, EventArgs e)
        {
            if (boxIfOkresDluzszyNo.Checked == true) boxIfOkresDluzszyYes.Checked = false;
        }

        private void boxWhichPlayerRare_CheckedChanged(object sender, EventArgs e)
        {
            if (boxHaveHistoriaYes.Checked == true)
            {
                boxHaveHistoriaNo.Checked = false;
            }
        }

        private void boxWhichPlayerManiac_CheckedChanged(object sender, EventArgs e)
        {
            if (boxHaveHistoriaNo.Checked == true)
            {
                boxHaveHistoriaYes.Checked = false;
            }
        }
        //Metoda sprawdzająca czy użytkownik udzielił odpowiedzi na pytanie, jeśli nie to po naciśnięciu przycisku "Dalej"
        //nie wyświetla się kolejne pytanie
        private void CheckIfUserAnswered()
        {
            if (_whichQuestion == 0 && boxIfOldEnough.Checked == false && boxIfTooYoung.Checked == false) _whichQuestion = -1;
            if (_whichQuestion == 1 && boxSalaryAbove.Checked == false && boxSalaryBelow.Checked == false) _whichQuestion = 0;
            if (_whichQuestion == 2 && boxIfHasEtatYes.Checked== false && boxIfHasEtatNo.Checked == false) _whichQuestion = 1;
            if (_whichQuestion == 3 && boxIfHasUmowaYes.Checked == false && boxIfHasUmowaNo.Checked == false) _whichQuestion = 2;
            if (_whichQuestion == 4 && boxIfHasOkresYes.Checked == false && boxIfHasOkresNo.Checked == false) _whichQuestion = 3;
            if (_whichQuestion == 5 && boxIfHasDzialalnoscYes.Checked == false && boxIfHasDzialalnoscNo.Checked == false) _whichQuestion = 4;
            if (_whichQuestion == 6 && boxIfDzialalnoscPolskaYes.Checked == false && boxIfDzialalnoscPolskaNo.Checked == false) _whichQuestion = 5;
            if (_whichQuestion == 7 && boxIfOkresDluzszyYes.Checked == false && boxIfOkresDluzszyNo.Checked == false) _whichQuestion = 6;
            if (_whichQuestion == 8 && boxHaveHistoriaYes.Checked == false && boxHaveHistoriaNo.Checked == false) _whichQuestion = 7;
            if (_whichQuestion == 9 && boxHistoriaPozytywnaYes.Checked == false && boxHistoriaPozytywnaNo.Checked == false) _whichQuestion = 8;
        }
        
        private void CheckIfUserCanContinue()
        {
            if (_whichQuestion == 0 && boxIfTooYoung.Checked == true) _canContinue=false;
            if (_whichQuestion == 1 && boxSalaryBelow.Checked == true) _canContinue = false;
            if (_whichQuestion == 8 && boxHaveHistoriaYes.Checked == false && boxHaveHistoriaNo.Checked == true) _canContinue=false;
            if (_whichQuestion == 9 && boxHistoriaPozytywnaYes.Checked == false && boxHistoriaPozytywnaNo.Checked == true) _canContinue = false;
            if (_whichQuestion == 4 && boxIfHasOkresYes.Checked == false && boxIfHasOkresNo.Checked == true) _canContinue = false;
            if (_whichQuestion == 5 && boxIfHasDzialalnoscYes.Checked == false && boxIfHasDzialalnoscNo.Checked == true) _canContinue = false;
            if (_whichQuestion == 6 && boxIfDzialalnoscPolskaYes.Checked == false && boxIfDzialalnoscPolskaNo.Checked == true) _canContinue = false;
            if (_whichQuestion == 7 && boxIfOkresDluzszyYes.Checked == false && boxIfOkresDluzszyNo.Checked == true) _canContinue = false;
        }
        private void ShowSummary()
        {
            _canContinue = true;
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
