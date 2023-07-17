import React from 'react'
import { FaTimes } from 'react-icons/fa'
import styles from './Popup.module.css'

const Popup = ({ active, setActive, drugResults, drugInteraction }) => {
	const handleClick = e => {
		e.preventDefault()
		setActive(!active)
	}

	return (
		<>
			<div className={`blur ${active ? 'active' : ''}`} onClick={handleClick}></div>
			<div className={`popup ${active ? 'active' : ''}`}>
				<div className={styles.resultContainer}>
					<FaTimes onClick={handleClick} />
					<h5 className='section-title'>
						Results
					</h5>
					<span className='line'></span>
					{drugResults.map((result, idx) => (
					<div
						key={idx}
						className={styles.result}
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
				<h6>Drug Interaction Results</h6>
				{drugInteraction.map((result, idx) => (
					<p
						key={idx}
						className={styles.drugInteraction}
					>
						{result}
					</p>
				))}
				</div>
			</div>
		</>
	)
}

export default Popup
