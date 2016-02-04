# MoSoWT

P. prostredie: Visual Studio 2015 P. jazyk: C# Windows Forms Application

Form1.Designer.cs - GUI

Interop.cs a WlanApi.cs je potrebné mať ako zvlášť triedy v projekte.
SharpPcap knižnice je nutné pridať do projektu ako referencie, link - http://sourceforge.net/projects/sharppcap/

Form1.cs funkcie:

začína sa kliknutím na "START MONITOR" -> button1Click()

wifiInfo() - vypisuje informácie získané zo sieťového rozhrania, je tam timer nastavený na 100 milisekund po ktorých sa aktualizujú informácie, tento časovač je na 100 ms aby sa informácie aktualizovali čo najrýchlejšie,

        - sú tu použité funkcie pridanej knižnice "Native Wifi" ref->
        https://msdn.microsoft.com/en-us/library/windows/desktop/ms706275(v=vs.85).aspx

        - na získanie informácií o sieťovom rozhraní je použitá štruktúra "WLAN_BSS_ENTRY" odkaz->
        https://msdn.microsoft.com/en-us/library/windows/desktop/ms706839(v=vs.85).aspx
capturing() - vytvára štatistiku na základe odchytených TCP/UDP paketov, zobrazí ju po kliknutí na "GET STATISTICS" -> button2_Click() - vypočítava rýchlosť v paketoch za sekundu a B/s zo ziskanych udajov

        - sú tu použité funkcie pridanej knižnice "SharpPcap" ref->
        http://sharppcap.sourceforge.net/htmldocs/index.html

        - použitím "WinPcapDevice" je možné využiť "OnPcapStatistics" a tým odchytávať pakety 
        a zároveň robiť ich štatistiku

        - časovať "readTimeoutMilliseconds" je nastavený na 1000 (1 sekunda) a tým je možné 
        po uplinutí timeoutu vypočítať rýchlosť prijímania dát či už v paketoch/s alebo v B/s
        (hodnoty downloadu a uploadu by bolo možné získať aj z vyššie spomenutej štruktúry "WLAN_BSS_ENTRY" 
        pokial by sa vo funkcii "wifiInfo()" nastavil časovač na 1000 ms)
