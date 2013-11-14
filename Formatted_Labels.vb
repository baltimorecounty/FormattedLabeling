Function FindLabel ( [FIRSTDIVISIONID] )
If Left([FIRSTDIVISIONID],1) = "C" Then
  FindLabel = Left([FIRSTDIVISIONID],4) &":"&Mid( [FIRSTDIVISIONID] ,5)
Else
If Left([FIRSTDIVISIONID],1) = "M" Then
  FindLabel = Left([FIRSTDIVISIONID],4) &":"&Mid( [FIRSTDIVISIONID] ,5)
Else
If Left([FIRSTDIVISIONID],1) <> "M"  Or Left([FIRSTDIVISIONID],1) <> "C" Then
  FindLabel = Left([FIRSTDIVISIONID],3) &":"&Mid( [FIRSTDIVISIONID] ,4)
End If
End If
End If
End Function