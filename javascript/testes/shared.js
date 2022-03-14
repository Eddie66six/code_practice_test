function formatarErro(str, strR){
    return 'parametro(s):' + str + ' esperado -> ' + strR;
}

function equalsObj(obj1, obj2){
    if(!obj1 || !obj2) return false;
    keysObj1 = Object.keys(obj1);
    keysObj2 = Object.keys(obj2);

    if(keysObj1.length != keysObj2.length) return false;
    var isEquals = true;
    for (const key in keysObj1) {
        if(keysObj1[key] != keysObj2[key]){
            isEquals = false;
            break;
        }
    }
    return isEquals;
}

exports.formatarErro = formatarErro;
exports.equalsObj = equalsObj;