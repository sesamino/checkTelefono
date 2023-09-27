# checkTelefono
### Come eseguire il test?
Dopo aver ricevuto un vettore di string ,bisogna dover ritornare la prima stringa che debba assomiliare ad un numero di telefono italiano e che quindi contenga queste caratteristiche:
* inizia con +39 (esattamente lungo  13)
* inizia con 0039 (esattamente lungi 14)
* inizia con un 3 (esattamente lungo 10)


Se il numero non viene trovato, ritornare stringa vuota ""
esempi:
>* Se arriva "05417373", "3367726712",  "778823" , tornare "3367726712"
>* Se arriva "33677267", "33677232",  "778823" , tornare ""
>* Se arriva "", "05417723",  "+391231231234", tornare "+391231231234"
>* Se arriva "3", "05417723",  "00391231231230" , tornare ""

### Come procedere?

Inizialmente dichiarare le due variabili che verrano successivamented utilizzate all'interno del codice:
```
int i;
string num;
```
Inserisco poi un for che servirà  per poter scorrere il vettore ,al quale dentro la condizione vi inserisco tre if con le tre diverse condizioni iniziali date dal esercizio:
```
 for(i=0;i<input.Length;i++){
            num = input[i];
            if(num[0]=='+' && num[1]=='3' && num[2]=='9'){
                return num;
            };
         if(num[0]=='0' && num[1]=='0' && num[2]=='3' && num[1]=='9'){
                return num;
            };
         if(num[0]=='3' ){
                return num;
            };

        };



```
Nel primo if vi inserisco la condizone per la quale se all'inizio del numero vi è il +39(e quindi le prime tre celle del vettore ) mi restituisca il valore num :
```
if(num[0]=='+' && num[1]=='3' && num[2]=='9'){
                return num;
   };
```
Nel secondo if invece accade la stessa cosa del primo ma con una differente condizione ovvero chde  se  al inizio del numero vi è 003 allora mi ritorna il valore num:
```
if(num[0]=='0' && num[1]=='0' && num[2]=='3' && num[1]=='9'){
                return num;
            };
```
Nel terzo caso come negli altri due ,con condizione che se al inizio del numero vi sia 3 ho in ritorno il valore num:
```
if(num[0]=='3' ){
                return num;
            };
```

