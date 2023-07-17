import React, { useState } from 'react'
import { useMutation, useQuery } from 'react-query'
import {
	getDrugs,
	checkInteraction,
	checkDrugInteraction,
} from '../../../../services/drugService'

import { FaTimes } from 'react-icons/fa'
import Layout from '../../layouts/Layout'
import styles from './SearchDrug.module.css'
import { useSelector } from 'react-redux'

export default function SearchDrug() {
	const drugsQuery = useQuery('drugs', getDrugs)

	const [drugResults, setDrugResults] = useState([])

	const [drugInteraction, setDrugInteraction] = useState([])

	const { theme } = useSelector(state => state.theme)

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

	const [selectedDrugs, setSelectedDrugs] = useState([])

	const handleChange = barcode => {
		drugsQuery.data.data.result.forEach(drug => {
			if (drug.barcode === parseInt(barcode) && !selectedDrugs.includes(drug)) {
				setSelectedDrugs([...selectedDrugs, drug])
			}
		})
	}

	const handleDelete = id => {
		const newDrugs = selectedDrugs.filter(drug => drug.id !== id)
		setSelectedDrugs(newDrugs)
	}

	const handleCheckInteraction = () => {
		const barcodes = selectedDrugs.map(drug => drug.barcode)
		checkInteractionMutation.mutate(barcodes)
		checkDrugInteractionMutation.mutate(barcodes)
		// [8699548094408, 8699536092492, 8699532095473, 8699502013391] example barcode list
	}

	return (
		<Layout>
			<div className={styles.interaction}>
				<select onChange={e => handleChange(e.target.value)}>
					<option value=''>select drug</option>
					{!drugsQuery.isLoading &&
						drugsQuery.data.data.result.map(drug => (
							<option value={drug.barcode} key={drug.id}>
								{drug.name.toLowerCase()}
							</option>
						))}
				</select>
				<div className={styles.drugs}>
					{selectedDrugs.map((drug, idx) => (
						<div key={drug.id} className={styles.drug}>
							<span>
								{idx + 1} - {drug.name.toLowerCase()}
							</span>{' '}
							<FaTimes onClick={() => handleDelete(drug.id)} />
						</div>
					))}
				</div>
				<div>
					<button onClick={handleCheckInteraction}>check interactions</button>
				</div>
				<div>
					<h5 className={`section-title ${theme === 'dark' && styles.dark}`}>
						Results
					</h5>
					<span className='line'></span>
					{drugResults.map((result, idx) => (
						<div
							key={idx}
							className={`${styles.result} ${theme === 'dark' && styles.dark}`}
						>
							<h6>Drug {idx + 1}</h6>
							<p>
								<span>Active Substance</span>: {result.drug.activeSubstance}
							</p>
							<p>
								<span>Food Interaction</span>:{' '}
								{result.foodInteraction.description}
							</p>
							<p>
								<span>Recommendation Contraindication</span>:{' '}
								{result.recommendation.contraindication}
							</p>
							<p>
								<span>Recommendation Indication</span>:{' '}
								{result.recommendation.indication}
							</p>
							<p>
								<span>Side Effects</span>: {result.recommendation.sideEffect}
							</p>
						</div>
					))}
					<br />
					<br />
					{drugInteraction.map((result, idx) => (
						<p
							key={idx}
							className={`${styles.drugInteraction} ${
								theme === 'dark' && styles.dark
							}`}
						>
							{result}
						</p>
					))}
				</div>
			</div>
		</Layout>
	)
}
