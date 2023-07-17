import React from 'react'
import styles from './SystemInfo.module.css'

export default function SystemInfo({ handleClose }) {
	const handleClick = () => {
		handleClose(false)
	}

	return (
		<>
			<div className={styles.container}>
				<h3>System Information</h3>
				<p>
					Fistly, welcome to our system. Phacec is the first application that
					allows users to check drug-drug and drug-food interactions. If you
					don't know where to start, this manual will help you to use the system
					efficently. You can continue reading manual if you need help.
				</p>
				<p>
					<strong>Step One</strong>: Open the interaction page using side menu.
				</p>
				<p>
					<strong>Step Two</strong>: Select the drugs that you want to learn
					about drug and food interactions
				</p>
				<p>
					<strong>Step Three</strong>: Click the 'check interactions' button
				</p>
				<p>
					<strong>Note:</strong> You can remove drugs by clicking <span className='text-danger'>X</span> icon.
				</p>
				<strong className={styles.feedback}>
					You can provide us feedback on give advice page.
				</strong>
				<button onClick={handleClick}>I understand</button>
			</div>
			<div className={styles.overlay} onClick={handleClick}></div>
		</>
	)
}
