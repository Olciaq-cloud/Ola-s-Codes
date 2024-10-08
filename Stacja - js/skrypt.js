function obl(){
    let pal = document.getElementsByName("pal").value;
    let lit = document.getElementsByName("lit").value;
    if(pal==1){
        let cal = 4*lit;
        document.getElementById("wynik").innerHTML="Koszt paliwa wynosi 4 zł za litr. Całkowity koszt tankowania będzie wynosił"+cal+"";
    }
    if(pal==2){
        let cal = 3.5*lit;
        document.getElementById("wynik").innerHTML="Koszt paliwa wynosi 3,5 zł za litr. Całkowity koszt tankowania będzie wynosił"+cal+"";
    }
    else{
        document.getElementById("wynik").innerHTML="Nie ma takiej możliwości koszt paliwa wynosi 0 zł gdyż nie ma takiej opcji";
    }
}