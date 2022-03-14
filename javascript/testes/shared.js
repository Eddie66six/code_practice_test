function formatarErro(str, strR){
    return 'parametro(s):' + str + ' esperado -> ' + strR;
}

function equalsObj(obj1, obj2){
    if(!obj1 || !obj2) return false;
    keysObj1 = Object.keys(obj1);
    keysObj2 = Object.keys(obj2);

    if(keysObj1.length != keysObj2.length) return false;
    var isEquals = true;
    for (let index = 0; index < keysObj1.length; index++) {
        const key = keysObj1[index];
        if(Array.isArray(obj1[key]) && Array.isArray(obj2[key])){
            if(obj1[key].length != obj2[key].length){
              isEquals = false;
              break;
            }
            isEquals = equalsListObjs(obj1[key], obj2[key]);
            if(!isEquals){
                isEquals = false;
                break;
            }
        }
        else if(typeof(obj1[key]) == 'object' && typeof(obj2[key]) == 'object'){
            isEquals = equalsObj(obj1[key], obj2[key]);
            if(!isEquals){
                isEquals = false;
                break;
            }
        }
        else if(obj1[key] != obj2[key]){
            isEquals = false;
            break;
        }
    }
    return isEquals;
}


function equalsListObjs(lst1, lst2){
  if(lst1.length != lst2.length) return false;
  var countEquals = 0;
  for (let index1 = 0; index1 < lst1.length; index1++) {
    for (let index2 = 0; index2 < lst1.length; index2++) {
      if(equalsObj(lst1[index1], lst2[index2])){
        countEquals++;
      }
    }
  }
  return countEquals == lst1.length;
}

exports.formatarErro = formatarErro;
exports.equalsObj = equalsObj;