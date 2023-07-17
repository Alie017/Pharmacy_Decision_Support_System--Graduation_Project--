import React from 'react'
import { useMutation } from 'react-query'
import { checkDrugInteraction, checkInteraction } from '../../services/drugService'

const LowerButtons = ({ active, setActive, drugs, setDrugResults, setDrugInteraction }) => {
	const checkInteractionMutation = useMutation({
		mutationFn: checkInteraction,
		onSuccess: data => {
			setDrugResults(data.data.result)
		},
	})

	const checkDrugInteractionMutation = useMutation({
		mutationFn: checkDrugInteraction,
		onSuccess: data => {
			setDrugInteraction(data.data.result)
		},
	})

	const handleClick = e => {
		e.preventDefault()
		const barcodes = drugs.map(drug => drug.barcode)
		checkInteractionMutation.mutate(barcodes)
		checkDrugInteractionMutation.mutate(barcodes)
		setActive(!active)
	}

	return (
		<div className='lower-buttons-section'>
			<button onClick={handleClick}>Kaydet</button>
			<button onClick={e => e.preventDefault()}>Sil</button>
			<button onClick={e => e.preventDefault()}>Yazdır</button>
			<button onClick={e => e.preventDefault()}>Yeni Reçete</button>
			<button onClick={e => e.preventDefault()}>ITS Karekod İşlemleri</button>
			<button onClick={e => e.preventDefault()}>Karekod Sonlandır</button>
		</div>
	)
}

export default LowerButtons
