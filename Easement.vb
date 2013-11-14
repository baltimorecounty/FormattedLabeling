'Labelling expression for easement to format using the deed field, which is a
'concatenation of the liber and folio, if it is populated.

Function FindLabel ( [DEED_REF] )
If IsNull([DEED_REF]) Then
	FindLabel = ""
Else
FindLabel = "L. " & Left([DEED_REF],5) & " F. " & Mid( [DEED_REF],6)
End If
End Function