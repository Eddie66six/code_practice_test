String formatarErro(String str, String strR){
    return 'parametro(s):' + str + ' esperado -> ' + strR;
}

bool equalsObj(Map<String, dynamic> obj1, Map<String, dynamic> obj2){
    if(obj1.keys.length != obj1.keys.length) return false;
    var isEquals = true;
    for (var key in obj1.keys) {
        if(obj1[key] is Map && obj2[key] is Map){
          isEquals = equalsObj(obj1[key], obj2[key]);
          if(!isEquals){
            isEquals = false;
            break;
          }
        }
        else if(obj1[key] is List && obj2[key] is List){
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
        else if(obj1[key] != obj2[key]){
          isEquals = false;
          break;
        }
    }
    return isEquals;
}

bool equalsListObjs(List<Map<String, dynamic>> lst1, List<Map<String, dynamic>> lst2){
  if(lst1.length != lst2.length) return false;
  var countEquals = 0;
  for (var map1 in lst1) {
    for (var map2 in lst2) {
      if(equalsObj(map1, map2)){
        countEquals++;
      }
    }
  }
  return countEquals == lst1.length;
}