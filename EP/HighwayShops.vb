Function FindLabel([HighwayShops.NAME], [HighwayShops.SHOP], [HighwayShops.CONTACT], [HighwayShops.CONTACT_TITLE], [HighwayShops.PHONE1], [HighwayShops.CONTACT_PHONE] ) 
  var = [HighwayShops.NAME]
  splitStr = Split(var, chr(32))
  for i = 0 to UBound(splitStr)
     tmpStr = Trim(splitStr(i))
      if len(tmpStr) > 0 then tmpStr = UCase(Left(tmpStr,1)) & LCase(Right(tmpStr, Len(tmpStr) -1))
  splitStr(i) = tmpStr
  next
  ProperCase = join(splitStr, " ")
  var = [HighwayShops.CONTACT]
  splitStr = Split(var, chr(32))
  for i = 0 to UBound(splitStr)
     tmpStr = Trim(splitStr(i))
      if len(tmpStr) > 0 then tmpStr = UCase(Left(tmpStr,1)) & LCase(Right(tmpStr, Len(tmpStr) -1))
  splitStr(i) = tmpStr
  next
  ProperCase2 = join(splitStr, " ")
  var = [HighwayShops.CONTACT_TITLE]
  splitStr = Split(var, chr(32))
  for i = 0 to UBound(splitStr)
     tmpStr = Trim(splitStr(i))
      if len(tmpStr) > 0 then tmpStr = UCase(Left(tmpStr,1)) & LCase(Right(tmpStr, Len(tmpStr) -1))
  splitStr(i) = tmpStr
  next
  ProperCase3 = join(splitStr, " ")
  FindLabel = ProperCase & " - " & "Shop " & [HighwayShops.SHOP] & vbNewLine & ProperCase2 & ", " & ProperCase3 & vbNewLine & "Shop Phone: " & "(" & (Left([HighwayShops.PHONE1],3)) &")" & " " & (Mid([HighwayShops.PHONE1],4,3)) & "-" & (Right([HighwayShops.PHONE1],4)) & vbNewLine & "Cell Phone: " & "(" & (Left([HighwayShops.CONTACT_PHONE],3)) &")" & " " & (Mid([HighwayShops.CONTACT_PHONE],4,3)) & "-" & (Right([HighwayShops.CONTACT_PHONE],4))
End Function
