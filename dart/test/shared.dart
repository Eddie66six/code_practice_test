String formatarErro(String str, String strR){
    return 'parametro(s):' + str + ' esperado -> ' + strR;
}

const _primitiveTypesPattern = ["int","double","num","String","bool"];

String? _isPrimitiveType(dynamic type){
  var _type = type.runtimeType.toString();
  if(_type.contains("List")){
    _type = _type.replaceAll("List", "").replaceAll("<", "").replaceAll(">", "");
  }
  if(_primitiveTypesPattern.contains(_type)){
    return _type;
  }
  return null;
}

bool _isMapStringDynamic(dynamic obj){
  return obj.runtimeType.toString() == "List<Map<String, dynamic>>";
}

bool equalsList(List<dynamic> lst1, List<dynamic> lst2){
  if(lst1.length != lst2.length) return false;
  var primitiveType1 = _isPrimitiveType(lst1);
  var primitiveType2 = _isPrimitiveType(lst2);
  if(primitiveType1 != primitiveType2) return false;

  var isPrimitive = primitiveType1 != null;
  var equals = false;
  for (var index = 0; index < lst1.length; index++) {
    equals = false;
    for (var index1 = 0; index1 < lst2.length; index1++) {
      if(isPrimitive){
        if(lst1[index] == lst2[index1]){
          equals = true;
          break;
        }
      }
      else if(!_isMapStringDynamic(lst1[index]) || !_isMapStringDynamic(lst2[index1])){
        equals = false;
        break;
      }
      else if(equalsObj(lst1[index], lst2[index1])){
        equals = true;
        break;
      }
    }
    if(!equals){
      break;
    }
  }
  return equals;
}

bool equalsObj(Map<String, dynamic> obj1, Map<String, dynamic> obj2){
    if(obj1.keys.length != obj2.keys.length) return false;
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
          if(obj1[key].runtimeType.toString() != "List<Map<String, dynamic>>") return false;
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
