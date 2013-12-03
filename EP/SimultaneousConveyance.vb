'Labelling expression for Simultaneous Conveyance to format the Conveyance ID like how
'the official Baltimore County Department of Permits, Approvals, and Inspections formats
'them. The format is XX-YYYY where XX is the election district and YYYY is the identifier
'padded with leading zeroes.

Function FindLabel ( [CONVEYANCE_ID] )
FindLabel = Left([CONVEYANCE_ID],2) &"-"&Mid( [CONVEYANCE_ID],3)
End Function