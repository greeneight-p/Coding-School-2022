const btnReverse = document.querySelector('#btnReverse');
btnReverse.addEventListener('click', reverseString);

const buttonCheckPal = document.querySelector('#btnCheckPal');
buttonCheckPal.addEventListener('click', checkPalindromeWord);

const btnAdd = document.querySelector('#btnAdd');
btnAdd.addEventListener('click', addRow);

const btnClear = document.querySelector('#btnClear');
btnClear.addEventListener('click', clearValues);

const btnShow = document.querySelector('#btnShow');
btnShow.addEventListener('click', showValues);

const btnInc = document.querySelector('#btnInc');
btnInc.addEventListener('click', incrementString);



var gindex=0;




function reverseString(){

    let word = document.querySelector("#word").value;
    let reversedWord = word.split('').reverse().join('');
    document.querySelector("#p1").innerHTML= "Reverse: "+word+" ==>> "+ reversedWord;
    document.querySelector("#word").value="";
}


function checkPalindromeWord(){
    word = document.querySelector("#word").value;
    reversedWord = word.split('').reverse().join('');
    if(word===reversedWord){
        document.querySelector("#p1").innerHTML= "Word: "+word+" ==>> Palindrome true";
        document.querySelector("#word").value="";
    }else{
        document.querySelector("#p1").innerHTML= "Word: "+word+" ==>> Palindrome false";
        document.querySelector("#word").value="";
    }
}

function addRow(){

    let name = document.querySelector("#name").value;
    let surname = document.querySelector("#surname").value;
    let age = document.querySelector("#age").value;
    let gender;
    if(document.getElementById('male').checked == true){
        gender = "male";
    }
    if(document.getElementById('female').checked == true){
        gender = "female";
    }

    //document.querySelector("#p1").innerHTML= name+surname+age+gender;


  let table = document.querySelector("#myTable")
  let newRow = table.insertRow(-1);

  let cell1 = newRow.insertCell(0);
  let cell2 = newRow.insertCell(1);
  let cell3 = newRow.insertCell(2);
  let cell4 = newRow.insertCell(3);

  let newText = document.createTextNode(name);
  cell1.appendChild(newText);
  newText = document.createTextNode(surname);
  cell2.appendChild(newText);
  newText = document.createTextNode(surname);
  cell3.appendChild(newText);
  newText = document.createTextNode(gender);
  cell4.appendChild(newText);

    clearValues();
    findRowIndex();
}

function clearValues(){
    document.querySelector("#name").value="";
    document.querySelector("#surname").value="";
    document.querySelector("#age").value="";
}
function findRowIndex(){
    var table1 = document.getElementById("myTable"), index;
    for(var i=0; i<table1.rows.length; i++){
        table1.rows[i].onclick = function(){
            index=this.rowIndex;
            gindex=index;
            console.log(index);
            
            }
    }
    
}


function showValues(){
    var table = document.getElementById('myTable');
                
    console.log(gindex);

    //rIndex = this.rowIndex;
    document.getElementById("name").value = table.rows[gindex].cells[0].innerHTML;
    document.getElementById("surname").value = table.rows[gindex].cells[1].innerHTML;
    document.getElementById("age").value = table.rows[gindex].cells[2].innerHTML;
    let gender = table.rows[gindex].cells[3].innerHTML;
    if (gender === "male"){
        document.getElementById("male").checked = true;
        return;
    }

    document.getElementById("female").checked = true;

}



function incrementString() {
    
    let word = document.querySelector("#word").value;
    /*profanos den ktlveno pos i parakato grammi kanei auto p zitaei i askisi, 
    to vrika sto internet kai fainetai na leitourgei swsta? */
    let text = word.replace(/(\d*)$/, (_, t) => (+t + 1).toString().padStart(t.length, 0));
    document.querySelector("#p1").innerHTML= "Increment: "+word+" ==>> "+ text;
    document.querySelector("#word").value="";
}




function multiply(a, b){
    if(isNaN(a)){
        return "First Value is not a number";
    }
    if(isNaN(b)){
        return "Second Value is not a number";
    }
    return a*b;
}




