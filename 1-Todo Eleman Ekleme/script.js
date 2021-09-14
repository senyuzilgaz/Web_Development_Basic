/*

const form = document.querySelector('form');

const task_list = document.querySelector('#task-list');
const del_all = document.querySelector('#btnDeleteAll');
const inp = document.querySelector('#txtTaskName');
let items =[];
eventListeners();
loadd();
function loadd(){
    console.log(localStorage);
    items = getFromLS();
    for(let i=0; i<items.length; ++i)
        create(items[i]);
}
function getFromLS(){
    
    if(localStorage.getItem('items')===null){
        items= [];
    }
    else{
        items= JSON.parse(localStorage.getItem('items'));
    }
    return items;
}
function setLS(){

    localStorage.setItem('items',JSON.stringify(items));
}

function array_remove(arr, item){
    return arr.filter(function(elem){
        return elem != item;
    })
}
function eventListeners(){
    form.addEventListener('submit', add);
    del_all.addEventListener('click',adelete);
    task_list.addEventListener('click',delete_item);
    
}
function load(){
    for(let i=0; i< items.length; ++i)
        create(items[i]);
}
function create(text){
    const new_task = document.createElement('li');
    const aa = document.createElement('a');
    new_task.className='list-group-item list-group-item-secondary';
    aa.className= 'delete-item float-right';
    aa.setAttribute('href','#');
    aa.innerHTML='<i class="fas fa-times"></i>';
    new_task.textContent= text;
    new_task.appendChild(aa);
    task_list.appendChild(new_task);
}

function add(e){
    
    if(inp.value===''){
        alert('Please enter task name');
        return;
    }
    create(inp.value);
    items.push(inp.value);
    inp.value = '';
    setLS();
    e.preventDefault();
}
function adelete(e){
    if( confirm('Are you sure?')){
        const listt= document.querySelectorAll('.list-group-item');
        for( let i=0;  i<listt.length; ++i){
            listt[i].remove();
            items.shift();

        }
    }
    localStorage.clear();
}
function delete_item(e){
    if(e.target.classList.contains('fa-times')){
        e.target.parentNode.parentNode.remove();
        console.log(e.target );
        items = array_remove(items, e.target.parentNode.parentNode.textContent);
        setLS();       
    }


}
*/



console.log("Damn");