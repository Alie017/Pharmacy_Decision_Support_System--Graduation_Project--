import React, { useState, useEffect } from 'react'
import { useParams } from 'react-router-dom'
import { data } from '../../data'

import UpperButtons from '../../components/UpperButtons'
import RecipeInfo from '../../components/RecipeInfo'
import LowerButtons from '../../components/LowerButtons'
import Prices from '../../components/Prices'
import DrugList from '../../components/DrugList'
import DrugInfo from '../../components/DrugInfo'
import Popup from '../../components/Popup'

import '../../medulla.css'

const Prescription = () => {
	const { tc, prescription } = useParams()

	const [active, setActive] = useState(false)

	const [prescriptionData, setPrescriptionData] = useState()

	// Interation result variables
	const [drugResults, setDrugResults] = useState([])

	const [drugInteraction, setDrugInteraction] = useState([])

	useEffect(() => {
		data.forEach(dataSingle => {
			if (dataSingle.tc === tc && dataSingle.prescriptionNo === prescription) {
				setPrescriptionData(dataSingle)
			}
		})
	}, [prescriptionData, tc, prescription])

	return (
		<div className='medulla'>
			<Popup
				active={active}
				setActive={setActive}
				drugResults={drugResults}
				drugInteraction={drugInteraction}
			/>
			<div className='wrapper'>
				<p className='title'>Reçete</p>
				<form>
					<UpperButtons prescription={prescription} />
					<RecipeInfo tc={tc} prescription={prescription} />
					<DrugInfo />
					{prescriptionData && <DrugList drugs={prescriptionData.drugs} />}
					<Prices />
					{prescriptionData && (
						<LowerButtons
							active={active}
							setActive={setActive}
							drugs={prescriptionData.drugs}
							setDrugResults={setDrugResults}
							setDrugInteraction={setDrugInteraction}
						/>
					)}
				</form>
			</div>
		</div>
	)
}

export default Prescription
