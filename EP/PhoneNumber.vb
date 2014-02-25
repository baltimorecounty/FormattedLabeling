Function FindLabel ( [PHONE] )
  FindLabel = "(" & (Left([PHONE],3)) &")" & "-" & (Mid([PHONE],4,3)) &"-" &(Right([PHONE],4))
End Function
